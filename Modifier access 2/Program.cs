using System;

namespace Modifier_access_2
{
    class Program : State
    {
        static void Main(string[] args)
        {
            Program state1 = new Program();

            //Console.WriteLine(state1.defaultVar);
            //Console.WriteLine(state1.privateVar);
            Console.WriteLine(state1.protectedPrivateVar);
            Console.WriteLine(state1.protectedVar);
            Console.WriteLine(state1.internalVar);
            Console.WriteLine(state1.protectedInternalVar);
            Console.WriteLine(state1.publicVar);

            state1.ProtectedPrivateMethod();
            state1.ProtectedMethod();
            state1.InternalMethod();
            state1.ProtectedInternalMethod();
            state1.PublicMethod();
        }
    }
}
