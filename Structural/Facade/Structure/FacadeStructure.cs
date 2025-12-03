namespace Structural.Facade.Structure
{
    public class FacadeStructure
    {
        public static void Main(string[] args)
        {
            var facade = new Facade();

            facade.MethodA();
            facade.MethodB();
        }
    }

    class SubsystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("Subsystem One: Method One");
        }
    }

    class SubsystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("Subsystem Two: Method Two");
        }
    }

    class SubsystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("Subsystem Three: Method Three");
        }
    }

    class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("SubSystem Four: Method Four");
        }
    }

    class Facade
    {
        private readonly SubsystemOne _subsystemOne;
        private readonly SubsystemTwo _subsystemTwo;
        private readonly SubsystemThree _subsystemThree;
        private readonly SubSystemFour _subSystemFour;

        public Facade()
        {
            _subsystemOne = new SubsystemOne();
            _subsystemTwo = new SubsystemTwo();
            _subsystemThree = new SubsystemThree();
            _subSystemFour = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("Facade: Method A");
            _subsystemOne.MethodOne();
            _subsystemTwo.MethodTwo();
            _subSystemFour.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("Facade: Method B");
            _subsystemThree.MethodThree();
            _subsystemTwo.MethodTwo();
        }
    }
}
