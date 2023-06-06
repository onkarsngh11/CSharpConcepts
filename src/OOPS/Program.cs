// Basic of OOPS
// Encapsulation
// Inheritance
// Abstraction
// Polymorphism

using OOPS;

Product product = new Mobile();
product.Name = "test";

Calculator calculator = new Calculator();
calculator.Multiply(3, 4, 5);

Instant instant = Instant.Method();

Console.WriteLine(numDecodings("12321310"));

int numDecodings(string s)
{
    int[] numberOfDecodings = new int[s.Length];
    int currentNum, nextNum;

    currentNum = int.Parse(s.ElementAt(s.Length - 1) + "");
    if (currentNum != 0)
        numberOfDecodings[s.Length - 1] = 1;
    else
        numberOfDecodings[s.Length - 1] = 0;


    for (int i = s.Length - 2; i >= 0; i--)
    {
        nextNum = currentNum;
        currentNum = Convert.ToInt32(s.ElementAt(i) + "");


        if (currentNum == 0)
            numberOfDecodings[i] = 0;
        else
        {
            if (currentNum >= 3 || (currentNum == 2 && nextNum >= 7)) //>26 <3
                numberOfDecodings[i] = numberOfDecodings[i + 1];

            else if (i + 2 <= s.Length - 1 && ((currentNum == 1 || currentNum == 2) && nextNum == 0)) //is less than length -1 and ceck 10 or 20
                numberOfDecodings[i] = numberOfDecodings[i + 2];

            else
            {
                if (i + 2 <= s.Length - 1)      //check less than length
                    numberOfDecodings[i] = numberOfDecodings[i + 1] + numberOfDecodings[i + 2];
                else
                {
                    if ((currentNum == 1 || currentNum == 2) && nextNum == 0)
                        numberOfDecodings[i] = 1;
                    else
                        numberOfDecodings[i] = 2;
                }
            }
        }
    }


    return numberOfDecodings[0];
}