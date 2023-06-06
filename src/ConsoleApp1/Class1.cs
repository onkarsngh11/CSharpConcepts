namespace ConsoleApp1
{
    public class Singleton
    {
        static Singleton s_myInstance = null;
        private Singleton()
        {
            if (s_myInstance == null)
                s_myInstance = new Singleton();
        }

        // Very simplistic implementation (not thread safe, not disposable, etc)
        public Singleton Instance
        {
            get
            {
                return s_myInstance;
            }
        }
        // More ordinary members here. 
    }

    public class A
    {
        static A()
        {
            Console.WriteLine("from A");
        }

        public virtual void Method()
        {
            Console.WriteLine("Method A");
        }
    }
    public static class StaticExample
    {
        private StaticExample()
        {

        }
    }

    public class B : A
    {
        static B()
        {
            Console.WriteLine("from B");
        }

        public B()
        {

        }

        public override void Method()
        {
            Console.WriteLine("Method B");
        }

        public static void MethodB()
        {
            Console.WriteLine("static Method B");
        }
    }
}
