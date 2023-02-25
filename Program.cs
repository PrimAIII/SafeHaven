// See https://aka.ms/new-console-template for more information
// A skeleton of a C# program
using System;



/*class PAITools
{
    private char A = 'a';
    private char B = 'b';
    private char C = 'c';
    public char Lab()
    {
        return A;
    }
    public char Lab2()
    {
        return B;
    }
    public char Lab3()
    {
        return C;
    }
}*/

public class Transaction
{
    public decimal Balance
    {
        get
        {
            decimal balance = 10;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }
    }
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public Transaction(decimal amount, DateTime date, string note)
    {
        Amount = amount;
        Date = date;
        Notes = note;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        var deposit = new Transaction(amount, date, note);
        allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        var withdrawal = new Transaction(-amount, date, note);
        allTransactions.Add(withdrawal);
    }

    private List<Transaction> allTransactions = new List<Transaction>();
}

public class BankAccount
{
    private static int accountNumberSeed = 1234567890;

    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }

    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name;
        this.Balance = initialBalance;
        this.Number = accountNumberSeed.ToString();
        accountNumberSeed++;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        //this is a paper slip
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        //this is a paper slip
    }
}

public class Laboratory
{
    private static int Fruitmentations = 377;

    public string Genome { get; }
    public char Tag { get; set; }
    public decimal Mitochondria { get; }

    public Laboratory(string name, char tagLabel)
    {
        this.Genome = name;
        this.Tag = tagLabel;
        this.Mitochondria = Fruitmentations;
        Fruitmentations++;
    }

    public void ChangeGenome(decimal amount, DateTime date, char note)
    {
        //this is a paper slip
    }

    public void MakeWithdrawal(decimal amount, DateTime date, char note)
    {
        //this is a paper slip
    }
}



class PAI
{
    static void Main()
    {
        // This line prints "Hello, World" 
        Console.WriteLine("Hello, World");

        Console.WriteLine("Hello, World!");
        Console.WriteLine("The current time is " + DateTime.Now);
        string MyWorld = "My World is a Marvel";
        Console.WriteLine(MyWorld);
        MyWorld = MyWorld.Replace("World", "Life");
        Console.WriteLine(MyWorld);
        string SongLyrics = "Nothing else matters, except love";
        var result = SongLyrics.StartsWith("love");
        Console.WriteLine(result);
        Console.WriteLine(SongLyrics.Contains("matters"));
        string SongLyrics1 = "Love of my life, you've hurt me";
        var result1 = SongLyrics1.StartsWith("Love");
        Console.WriteLine(result1);
        Console.WriteLine(SongLyrics1.Contains("life"));
        int character = 1;
        int energy = 2;
        int creativity = 3;
        int health = 4;
        int intuition = 5;
        int labour = 6;
        int luck = 7;
        int duty = 8;
        int memory = 9;
        int bernello = character + energy + creativity + health + luck + duty + memory;
        int division = energy / creativity;
        Console.WriteLine(bernello);
        Console.WriteLine($"quotient: {division}");
        int division2 = luck / energy;
        Console.WriteLine($"quotient: {division2}");
        int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"The range of integers is {min} and {max}");
        int what = max + 3;
        Console.WriteLine($"An example of overflow: {what}");
        double max2 = double.MaxValue;
        double min2 = double.MinValue;
        Console.WriteLine($"The range of double is {min2} to {max2}");
        double third = 1.0 / 3.0;
        Console.WriteLine(third);
        decimal min3 = decimal.MinValue;
        decimal second = decimal.MaxValue;
        Console.WriteLine($"The range of the decimal type is {min3} to {second}");
        decimal third2 = decimal.MinValue;
        decimal second2 = decimal.MaxValue;
        decimal third3 = decimal.MinValue;
        int min4 = int.MaxValue;
        int second4 = int.MinValue;
        const int min5 = int.MaxValue;
        const int min6 = int.MaxValue;
        long min7 = long.MinValue;
        long second7 = long.MaxValue;
        short min8 = short.MinValue;
        short second8 = short.MaxValue;
        double radius = 5.0;
        double area = radius * radius;
        Console.WriteLine(area);

        char neuron = 'A';
        char neuron1 = 'B';
        char neuron3 = 'C';
        char neuron4 = 'D';
        char neuron5 = 'E';
        char neuron6 = 'S';

        //dvelpomnet 

        string neur = "A";
        string neur1 = "B";
        string neur3 = "C";
        string neur4 = "D";
        string neur5 = "E";
        string neur6 = "F";
        string neur7 = "G";
        string neur8 = "F";
        string neur9 = "H";

        List<string> NeuronDatabase = new List<string>();
        //The following code snippet adds items to the list.

        NeuronDatabase.Add("Long");
        NeuronDatabase.Add("Short");
        NeuronDatabase.Add("Character");
        NeuronDatabase.Add("Intuition");
        NeuronDatabase.Add("Health");
        NeuronDatabase.Add("Luck");

        //Alternatively, we can also pass an array of objects to create a List object.The following code snippet creates a List object from an array of strings.

        for(int i = 0; i < NeuronDatabase.Count; i++)
        {
            Console.WriteLine(NeuronDatabase[i]);

        }

// Create a List using Range    
/*string[] authors = { "Mike Gold", "Don Box",
                        "Sundar Lal", "Neel Beniwal" };
        List<string> authorsRange = new List<string>(authors);*/
        //The following code snippet creates a list of integer type.

//List<int> AgeList = new List<int>();
        //The following code snippet adds items to the dictionary.

        /*AgeList.Add(35);
        AgeList.Add(25);
        AgeList.Add(29);
        AgeList.Add(21);
        AgeList.Add(84);*/
        //We can also limit the size of a list.The following code snippet creates a list where the key type is float and the total number of items it can hold is 3.

        //List<float> PriceList = new List<float>(3);
        //The following code snippet adds items to the list.

        /*PriceList.Add(3.25f);
        PriceList.Add(2.76f);
        PriceList.Add(1.15f);*/

        var account = new BankAccount("<Bernello Gabon>", 123456789);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

        for (int i = 0; i < 9; i++) 
        {
            /*Console.WriteLine(PAITools.Lab());
            Console.WriteLine(PAITools.Lab2());
            Console.WriteLine(PAITools.Lab3());*/

            Console.WriteLine(neur);
        }

        int counter = 0;
        while (counter < 10)
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
            Console.WriteLine(char.MinValue);
            Console.Write(nameof(counter));
            counter = 0;
            while (counter < 10) ;
          
            counter++;
        }
    }
}




