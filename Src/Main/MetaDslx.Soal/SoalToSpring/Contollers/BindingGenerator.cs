using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal.SoalToSpring.Contollers
{
    public class BindingGenerator
    {
        private SpringInterfaceGenerator springInterfaceGen;

        public BindingGenerator(SpringInterfaceGenerator springInterfaceGen)
        {
            this.springInterfaceGen = springInterfaceGen;
        }

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

        public List<Binding> GetBindings(Namespace ns, Port interfaceReference, Interface iface)
        {
            HashSet<Binding> bindings = new HashSet<Binding>();

            if (interfaceReference.Binding != null)
            {
                bindings.Add(interfaceReference.Binding);
            }

            foreach (Composite composite in ns.Declarations.OfType<Composite>())
            {
                foreach (Wire wire in composite.Wires)
                {
                    Port port = null;
                    if (wire.Source.Equals(interfaceReference))
                    {
                        port = wire.Target;
                    }
                    if (wire.Target.Equals(interfaceReference))
                    {
                        port = wire.Source;
                    }
                    if (port != null)
                    {
                        if (port.Binding != null)
                        {
                            bindings.Add(port.Binding);
                        }
                    }
                }
            }

            foreach (Component component in ns.Declarations.OfType<Component>())
            {
                foreach (Reference reference in component.References)
                {
                    if (reference.Interface.Equals(iface))
                    {
                        if (reference.Binding != null)
                        {
                            bindings.Add(reference.Binding);
                        }
                    }
                }
            }

            return new List<Binding>(bindings);
        }
    }
}
