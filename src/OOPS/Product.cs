namespace OOPS
{
    public abstract class Product
    {
        //Encapsulated property
        private int id;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public float Discount { get; set; }
        public abstract float DiscountCalculator();
    }

    public class Mobile : Product
    {

        public void CanPerformCallOperation()
        {

        }

        public override float DiscountCalculator()
        {
            throw new NotImplementedException();
        }
    }

    public class Shoes : Product
    {

        public void CanProvideComfortWhileWalking()
        {

        }

        public override float DiscountCalculator()
        {
            throw new NotImplementedException();
        }
    }

    public class Chair : Product
    {
        public override float DiscountCalculator()
        {
            throw new NotImplementedException();
        }
    }
}

public class Calculator
{
    public float Multiply(float x, float y, float z)
    {
        return x * y * z;
    }

    public float Multiply(float x, float y)
    {
        return x * y;
    }
}

public class Instant
{
    public static Instant Method()
    {
        return new Instant();
    }
}

