using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal
{
    class BindingTypeHolder
    {
        private bool restBinding = false;
        private bool webServiceBinding = false;
        private bool webSocketBinding = false;

        public bool HasRestBinding
        {
            get
            {
                return restBinding;
            }

            set
            {
                restBinding = value;
            }
        }

        public bool HasWebServiceBinding
        {
            get
            {
                return webServiceBinding;
            }

            set
            {
                webServiceBinding = value;
            }
        }

        public bool HasWebSocketBinding
        {
            get
            {
                return webSocketBinding;
            }

            set
            {
                webSocketBinding = value;
            }
        }
    }
}
