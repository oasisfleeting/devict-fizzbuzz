using System.IO;
using System;

class FizzBuzz
{
    private string fizz;
    private string buzz;
    
    public FizzBuzz(string fizz, string buzz)
    {
        this.fizz = fizz;
        this.buzz = buzz;
    }
    
    public string Burp {get{return fizz;}}
    public string SuperBurp {get{return buzz;}}
    public string Derp {get{return Burp + SuperBurp;}}
    
    public void GetBuzzed(int OneHundredBottlesOfBeerOnTheWall)
    {        
        for(int beer=1; beer<=OneHundredBottlesOfBeerOnTheWall; beer++)
        {
            if(beer%3 == 0 && beer%5 == 0)
                Beer.Drink(this.Derp);  
            else if(beer%3 == 0)                
                Beer.Drink(this.Burp);
            else if(beer%5 == 0)
                Beer.Drink(this.SuperBurp);  
            else
                Beer.Drink(beer.ToString());
        }
    }
}

class Beer
{
    public static void Drink(String gas)
    {
        Console.WriteLine(gas);
    }
}

class GetDrunk
{       
    public static void Main()
    {
        int OnBeer = 100;
        FizzBuzz ILoveTo = new FizzBuzz("fizz", "buzz");        
        ILoveTo.GetBuzzed(OnBeer);
    }
}
    
