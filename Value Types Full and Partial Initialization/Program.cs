using System;

//ref link:https://www.youtube.com/watch?v=Fxs_GRiSR5g&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=12
// Struct initialization
//  Full initialization - for function call, partial initialization - for partial datamember call

struct Fraction
{
    public int numerator;
    public int denominator;
    public void Reduce() { }
}

class MainClass
{
    static void Main()
    {
        Fraction myFrac = new Fraction(); // this will zero out all datamembers in the stack
        //Fraction myFrac;
        myFrac.numerator = 5;
        //myFrac.Reduce();    // error need initialize value
        //Console.WriteLine(myFrac.numerator);
        //Console.WriteLine(myFrac.denominator); // error need initialize value
        myFrac.denominator = 13;
        myFrac.Reduce();
    }
}