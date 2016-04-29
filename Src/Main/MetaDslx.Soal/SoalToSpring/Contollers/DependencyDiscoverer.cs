using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal.SoalToSpring.Contollers
{
    public class DependencyDiscoverer
    {
        private BindingDiscoverer bindingGenerator;

        public DependencyDiscoverer(BindingDiscoverer bindingGenerator)
        {
            this.bindingGenerator = bindingGenerator;
        }

        public List<string> GetherDependencies(Dictionary<Reference, Component> dependecyMap)
        {
            // collecting module dependencies
            List<string> dependencies = new List<string>();
            foreach (KeyValuePair<Reference, Component> entry in dependecyMap)
            {
                List<Binding> bindings = new List<Binding>();
                Reference reference = entry.Key;
                Component comp = entry.Value;
                string businessComponentName = comp.Name;
                if (businessComponentName.Contains("-API") || businessComponentName.Contains("-WEB"))
                {
                    businessComponentName = businessComponentName.Split(new string[] { "-API", "-WEB" }, StringSplitOptions.RemoveEmptyEntries)[0];
                }
                foreach (Service service in entry.Value.Services)
                {
                    if (service.Interface.Equals(reference.Interface) && service.Binding != null)
                    {
                        bindings.Add(service.Binding);
                    }
                }
                if (reference.Binding != null)
                    bindings.Add(reference.Binding);
                BindingTypeHolder binding = bindingGenerator.CheckForBindings(bindings);

                if (binding.hasAnyBinding())
                {
                    if (!dependencies.Contains(businessComponentName + "-API") && !dependencies.Contains(businessComponentName))
                    {
                        dependencies.Add(businessComponentName + "-API");
                    }
                }
                else
                {
                    if (!dependencies.Contains(businessComponentName))
                    {
                        dependencies.Add(businessComponentName);
                        dependencies.Remove(businessComponentName + "-API");
                    }
                }
            }
            return dependencies;
        }

        // collecting module dependencies
        public Dictionary<Reference, Component> GetherDependencyMap(Namespace ns, List<Wire> wires, Component component)
        {
            Dictionary<Reference, Component> dependencies = new Dictionary<Reference, Component>();
            foreach (Reference reference in component.References)
            {
                bool referenceStatisfied = false;
                foreach (Wire wire in wires)
                {
                    if (wire.Source.Equals(reference))
                    {
                        Component comp = wire.Target.Component;
                        Service target = wire.Target as Service;
                        if (target != null)
                        {
                            referenceStatisfied = true;
                            PutDependecy(dependencies, reference, target, comp);
                        }
                    }
                }
                if (!referenceStatisfied)
                {
                    foreach (Component comp in ns.Declarations.OfType<Component>())
                    {
                        foreach (Service serv in comp.Services)
                        {
                            if (serv.Interface.Equals(reference.Interface))
                            {
                                PutDependecy(dependencies, reference, serv, comp);
                            }
                        }
                    }
                }
            }
            return dependencies;
        }

        private void PutDependecy(Dictionary<Reference, Component> dependencies, Reference reference, Service serv, Component comp)
        {
            List<Binding> bindings = new List<Binding>();
            if (serv.Binding != null)
                bindings.Add(serv.Binding);
            if (reference.Binding != null)
                bindings.Add(reference.Binding);
            BindingTypeHolder binding = bindingGenerator.CheckForBindings(bindings);

            Component api = new ComponentImpl();
            api.Name = comp.Name + "-API";
            api.BaseComponent = comp;

            if (binding.hasAnyBinding())
            {
                dependencies.Add(reference, api);
            }
            else
            {
                dependencies.Add(reference, comp);
            }
        }
    }
}
