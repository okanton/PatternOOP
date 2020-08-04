﻿using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent();
            Decorator decoratorA = new ConcreteDecoratorA();
            Decorator decoratorB = new ConcreteDecoratorB();

            decoratorA.Component = component;
            decoratorB.Component = decoratorA;
            decoratorB.Operation();

            Console.Read();
        }
    }
}
