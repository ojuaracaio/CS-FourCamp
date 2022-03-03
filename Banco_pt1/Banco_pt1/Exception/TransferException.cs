using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_pt1.Exception
{

    [Serializable]
    public class TransferException : System.Exception
    {
        public TransferException() { }
        public TransferException(string message) : base(message) { }
        public TransferException(string message, System.Exception inner) : base(message, inner) { }
        protected TransferException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
