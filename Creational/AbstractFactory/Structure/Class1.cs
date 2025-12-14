using System;

namespace Structure;

public class Class1 { }

abstract class AbstractProductA { }

abstract class AbstractProductB
{
    public abstract void Interact(AbstractProductA a);
}

class ProductA1 : AbstractProductA { }

class ProductA2 : AbstractProductA { }

class ProductB1 : AbstractProductB
{
    public override void Interact(AbstractProductA a)
    {
        Console.WriteLine(GetType().Name + " interacts with " + a.GetType().Name);
    }
}

class ProductB2 : AbstractProductB
{
    public override void Interact(AbstractProductA a)
    {
        Console.WriteLine(GetType().Name + " interacts with " + a.GetType().Name);
    }
}

class Client
{
    private AbstractProductA abstractProductA;
    private AbstractProductB abstractProductB;
}
