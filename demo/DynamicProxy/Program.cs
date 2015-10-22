﻿using System;

namespace DynamicProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var concrete = new Foo();

            var proxy = ProxyBuilder.CreateProxy<IFoo>(
                    concrete,
                    beforeExecuteAction: (s, o) =>
                        Console.WriteLine("Before execute {0}", s),
                    afterExecuteAction: (s, o) =>
                        Console.WriteLine("After execute: {0}", s)
                );

            proxy.SayHello();
            Console.ReadLine();
        }
    }


    public class Foo : IFoo
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IFoo
    {
        int Add(int a, int b);
        void SayHello();
    }
}
