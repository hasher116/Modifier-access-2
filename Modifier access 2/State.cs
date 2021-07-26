using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifier_access_2
{
    public class State
    {
        int defaultVar = 1;
        private int privateVar = 2;
        protected private int protectedPrivateVar = 3;
        protected int protectedVar = 4;
        internal int internalVar = 5;
        protected internal int protectedInternalVar = 6;
        public int publicVar = 7;

        void DefaultMethod()
        {
            Console.WriteLine($"defaultVar = {defaultVar}");

        }
        private void PrivateMethod()
        {
            Console.WriteLine($"privateVar = {privateVar}");
        }
        protected private void ProtectedPrivateMethod()
        {
            Console.WriteLine($"protectedProvateVar = {protectedPrivateVar}");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine($"protectedVar = {protectedVar}");
        }
        internal void InternalMethod()
        {
            Console.WriteLine($"Internal Var = {internalVar}");
        }
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine($"protectedInternalVar = {protectedInternalVar}");
        }
        public void PublicMethod()
        {
            Console.WriteLine($"publicVar = {publicVar}");
        }

    }
}
