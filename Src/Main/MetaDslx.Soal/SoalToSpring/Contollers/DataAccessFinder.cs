using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal.SoalToSpring.Contollers
{
    public class DataAccessFinder
    {
        private BindingDiscoverer bindingGenerator;

        public DataAccessFinder(BindingDiscoverer bindingGenerator)
        {
            this.bindingGenerator = bindingGenerator;
        }

        public bool HasDirectDataAccess(Namespace ns, List<Wire> wires, Component component, string dataModule)
        {
            bool hasDirectDataAccess = false;
            foreach (Reference reference in component.References)
            {
                if (hasDirectDataAccess) // stop algorithm if found a direct access
                {
                    return true;
                }

                bool referenceStatisfied = false;
                foreach (Wire wire in wires)
                {
                    // Component comp = (Component)((ModelObject)port).MParent;
                    if (wire.Source.Equals(reference))
                    {
                        Service serv = wire.Target as Service;
                        if (serv != null)
                        {
                            hasDirectDataAccess = CheckDirectDataAccess(ns, wires, dataModule, reference, serv.Component, serv);
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
                                hasDirectDataAccess = CheckDirectDataAccess(ns, wires, dataModule, reference, comp, serv);
                            }
                        }
                    }
                }
            }
            return hasDirectDataAccess;
        }

        private bool CheckDirectDataAccess(Namespace ns, List<Wire> wires, string dataModule, Reference reference, Component comp, Service serv)
        {
            bool hasDirectDataAccess = false;
            List<Binding> bindings = new List<Binding>();
            if (serv.Binding != null)
                bindings.Add(serv.Binding);
            if (reference.Binding != null)
                bindings.Add(reference.Binding);
            BindingTypeHolder binding = bindingGenerator.CheckForBindings(bindings);

            if (!binding.hasAnyBinding())
            {
                // direct access
                if (comp.Name == dataModule)
                {
                    hasDirectDataAccess = true;
                }
                else
                {
                    // need to check
                    hasDirectDataAccess = HasDirectDataAccess(ns, wires, comp, dataModule);
                }
            }

            return hasDirectDataAccess;
        }


    }
}
