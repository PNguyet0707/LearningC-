using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Class
{
        internal class OuterClass
        {
                  
            private string _str = "Outer class field";
            private void OuterClassMethod() => Console.WriteLine("Outer class method");
            public void OuterMethodCallsPrivateInnerClassMethod()
            {
                PrivateInnerClass privateInner = new PrivateInnerClass();
                privateInner.Method();
            }
            public void OuterMethodsCallsPublicInnerClassMethod()
            {
                PublicInnerClass publicInner = new PublicInnerClass();
                publicInner.Method();
            }
            public  class PublicInnerClass
            {
                public void Method()
                {
                    Console.WriteLine("Inner public class method");
                    OuterClass outer = new OuterClass();
                    Console.WriteLine(outer._str);
                    outer.OuterClassMethod();
                }
            }
            private class PrivateInnerClass
            {
                public void Method()
                {
                    Console.WriteLine("Inner private class method");
                    OuterClass outer = new OuterClass();
                    Console.WriteLine(outer._str);
                    outer.OuterClassMethod();
                }
            }
        }
        internal class Program
        {
            private static void Main(string[] args)
            {
                OuterClass outer = new OuterClass();
                outer.OuterMethodCallsPrivateInnerClassMethod();
                outer.OuterMethodsCallsPublicInnerClassMethod();
                OuterClass.PublicInnerClass inner = new OuterClass.PublicInnerClass();
                inner.Method();
                Console.ReadKey();
            }
        }
    }

   