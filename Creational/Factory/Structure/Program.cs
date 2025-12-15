namespace DesignPatternPractice.Factory;

class Program
{
    static void Main(string[] args)
    {
        Creator[] creators = new Creator[2];

        creators[0] = new ConcreteCreatorA();
        creators[1] = new ConcreteCreatorB();

        foreach (var creator in creators)
        {
            Product product = creator.CreateProduct();
            Console.WriteLine($"Create {product.GetType().Name}");
        }
    }

    abstract class Product { }

    class ConcreteProductA : Product { }

    class ConcreteProductB : Product { }

    abstract class Creator
    {
        //Factory Method
        public abstract Product CreateProduct();
    }

    class ConcreteCreatorA : Creator
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductA();
        }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
