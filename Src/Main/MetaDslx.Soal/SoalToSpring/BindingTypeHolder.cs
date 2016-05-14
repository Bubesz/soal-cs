using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal
{
    public class BindingTypeHolder
    {
        public bool HasRestBinding { get; set; }

        public bool HasWebServiceBinding { get; set; }

        public bool HasWebSocketBinding { get; set; }

        public bool hasAnyBinding()
        {
            return HasRestBinding || HasWebServiceBinding || HasWebSocketBinding;
        }
    }
}
