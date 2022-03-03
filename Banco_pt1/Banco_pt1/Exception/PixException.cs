using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_pt1.Exception
{

    [Serializable]
    public class PixException : System.Exception
    {
        public PixException() { }
        public PixException(string message) : base(message) { }
        public PixException(string message, System.Exception inner) : base(message, inner) { }
        protected PixException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
