using Microsoft.VisualBasic;

namespace Structural.Adapter.Structure
{
    public class AdapterStructure
    {
        public static void Main(string[] args)
        {
            ITarget target = new Adapter();
            target.Request();
        }
    }

    public interface ITarget
    {
        public void Request();
    }

    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called Adaptee SpecificRequest");
        }
    }
}
