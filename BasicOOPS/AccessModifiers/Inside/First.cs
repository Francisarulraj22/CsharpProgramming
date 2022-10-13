using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{
    public class First:third
        {
        public int Number=10;
        
        private int Number1=20;
        public int PrivateOutPut{get{return Number1;}}

        internal int Number2=30;

        protected int Number3=40;
        public int Number5Output{get {return Number4;}}
    }
}