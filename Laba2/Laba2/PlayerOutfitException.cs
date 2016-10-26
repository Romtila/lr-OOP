using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba2
{
    class PlayerOutfitException : ApplicationException
    {
        public PlayerOutfitException() { }
        public PlayerOutfitException(string message) : base(message) { }

        protected PlayerOutfitException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext contex)
            : base(info, contex) { }
    }
}
