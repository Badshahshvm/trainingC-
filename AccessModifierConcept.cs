using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class AccessModifierConcept
    {
        private string privateInfo = "Private Info - Only within this class";
        public string publicInfo = "Public Info - Accessible everywhere";
        protected string protectedInfo = "Protected Info - Base & Derived classes";
        internal string internalInfo = "Internal Info - Same assembly";
        protected internal string protectedInternalInfo = "Protected Internal - Base/Derived/Same Assembly";

        public void ShowInfo()
        {
            Console.WriteLine("Inside AccessModifierConcept class:");
            Console.WriteLine(privateInfo);
            Console.WriteLine(publicInfo);
            Console.WriteLine(protectedInfo);
            Console.WriteLine(internalInfo);
            Console.WriteLine(protectedInternalInfo);
        }
    }

    class TestConcept : AccessModifierConcept
    {
        public void ShowDerivedClassAccess()
        {
            Console.WriteLine("\nInside TestConcept (Derived class):");
            // Console.WriteLine(privateInfo); ❌ Not accessible
            Console.WriteLine(publicInfo);             // ✅
            Console.WriteLine(protectedInfo);          // ✅ (accessible via inheritance)
            Console.WriteLine(internalInfo);           // ✅
            Console.WriteLine(protectedInternalInfo);  // ✅
        }
    }

}
