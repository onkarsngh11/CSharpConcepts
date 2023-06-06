public static class A
{
    static A()
    {
        Console.WriteLine("from a");
    }

    static void MethodA()
    {
        Console.WriteLine("A");
    }
}

public class B
{
    static B()
    {
        MethodB();
    }

    //private B()
    //{

    //}

    public B()
    {

    }

    public static void MethodB()
    {
        Console.WriteLine("from B");
    }
}

//B a = new B();
B.MethodB();

//static vs private const

