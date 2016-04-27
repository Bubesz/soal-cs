using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal.SoalToSpring.Contollers
{
    public class BindingDiscoverer
    {
        public BindingTypeHolder CheckForBindings(List<Binding> bindings)
        {
            BindingTypeHolder result = new BindingTypeHolder();

            foreach (Binding binding in bindings)
            {
                if (binding.Transport is RestTransportBindingElement)
                {
                    result.HasRestBinding = true;
                }
                else if (binding.Transport is WebSocketTransportBindingElement)
                {
                    result.HasWebSocketBinding = true;
                }
                else
                {
                    foreach (EncodingBindingElement encoding in binding.Encodings)
                    {
                        if (encoding is SoapEncodingBindingElement)
                        {
                            result.HasWebServiceBinding = true;
                        }
                    }
                }
            }

            return result;
        }

        public List<Binding> GetBindings(Namespace ns, Port port)
        {

            if (port.Interface.Name.Contains("Repository"))
            {
                foreach (Service service in port.Component.Services)
                {
                    Database db = service.Interface as Database;
                    if (db != null)
                    {
                        return GetBindings(ns, service);
                    }
                }
            }

            HashSet<Binding> bindings = new HashSet<Binding>();

            // check port
            if (port.Binding != null)
            {
                bindings.Add(port.Binding);
            }

            // check other side of wires
            foreach (Composite composite in ns.Declarations.OfType<Composite>())
            {
                foreach (Wire wire in composite.Wires)
                {
                    if (wire.Source.Equals(port))
                    {
                        bindings.Add(wire.Target.Binding);
                    }
                    if (wire.Target.Equals(port))
                    {
                        bindings.Add(wire.Source.Binding);
                    }
                }
            }

            // check references
            foreach (Component component in ns.Declarations.OfType<Component>())
            {
                foreach (Reference reference in component.References)
                {
                    if (reference.Interface.Equals(port.Interface))
                    {
                        if (reference.Binding != null)
                        {
                            bindings.Add(reference.Binding);
                        }
                    }
                }
            }

            // check services
            foreach (Component component in ns.Declarations.OfType<Component>())
            {
                foreach (Service service in component.Services)
                {
                    if (service.Interface.Equals(port.Interface))
                    {
                        if (service.Binding != null)
                        {
                            bindings.Add(service.Binding);
                        }
                    }
                }
            }

            bindings.Remove(null);
            return new List<Binding>(bindings);
        }
    }
}
