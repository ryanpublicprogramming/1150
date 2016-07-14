
// Part The First

// #1

int number = 42;
bool Life = true;
string LukeFather = "Darth Vader";
double dbl = 1.7;
decimal dec = 100.3m;

// #2

string BuildMessage(string LukeFather, int number)
{
    return $"Luke's Father is {LukeFather} The meaning of life is {number}";
}

// #3
var yup = BuildMessage(LukeFather, number);
Console.WriteLine(yup);

// #4
var Letters =
    new[]
    {
        "A",
        "B",
        "C",
        "D",
        "E",
        "F",
    };

// #5
foreach (var Letters in Letters) Console.WriteLine(Letters);

// Part The Second - 1 -{ 2 -3 - 4 - 5 -{ 10 - 9 }- 6 - 11 - 12 - 7 }- 8
// Could also be done by defining customer name, gender, list of purchases, and pinning time of that purchase.
// Then define a function that sends a link to an add page if inactive > 1 month, (current Date_Check - last_purchase Date_Check >= 30 days)
// That checks on the first of every month.


// # 1.2
public enum Gender
{
    Unknown,
    Male,
    Female,
}
// # 1.1
public class Customer
{
    // #2
    public Customer(string name, Gender gender, string purchases)
    {
        Name = name;
        Gender = gender;
        Purchases = purchases;
    }

    public string Name { get; set; }
    public Gender Gender { get; set; }
    public string Purchases { get; set; }

    // #3
    public void SayThanks()
    {
        Console.WriteLine($"Hello {Name}, You have Successfully Got {Purchases}. It will arive eventually.");
    }

    // #4 .1
    public static DateTime Now { get; }
    var saledate = DateTime;

    
    public void SendSaleNotice(DateTime saleDate)
    {
        Console.WriteLine($"Hello {Name}, We wanted to let you know there's a sale coming up on {saleDate:yyyy-MM-dd}");
    }
    // #4 .2

    public void SendSaleNotice(string Purchases, DateTime saleDate)
    {
        Console.WriteLine($"Yo {Name}, This Product, {product}, is really cool, bome buy it cheaper until {saleDate:yyyy-MM-dd}");
    }

    // #5
    public sealed class InactiveCustomer : Customer
    {
        // #10
        public enum InactiveReason
        {
            Hatred,
            Bored,
            Not Here,
            Other,
        }

        // #9
        public virtual void PrintCustomerInfo()
    {
        Console.WriteLine($"{Name} - {Gender} - {Purchases}");
    }
}

    // #6
    public InactiveCustomer(string name, Gender gender, string purchases, int monthsInactive) : base(name, gender, purchases)
    {
        MonthsInactive = monthsInactive;
    }

    public int MonthsInactive { get; set; }

    // #11
    public InactiveReason Why { get; set; }

    // #12
    public override void PrintCustomerInfo()
    {
        Console.WriteLine($"{Name} - {Gender} - {Purchases} - {Why}");
    }
    
    // #7
    public void SendInactiveMessage()
    {
        var message =
            new StringBuilder($"Thanks for your money, {Name}. ")
                .Append($"Buy more suff like {Purchases} and Why you no here in {MonthsInactive} months?? ")
                .Append("BUY MORE STUFF!!")
                .ToString();
        Console.WriteLine(message);
    }

}

// #8. New Instance of Customer
var customer = new Customer("Ann", Gender.Female, "Drugs");
customer.SayThanks();
customer.SendSaleNotice(DateTime.Parse("3000-01-01"));
customer.SendSaleNotice("LEGO", DateTime.Parse("3000-01-01"));
customer.PrintCustomerInfo();

// #8. New Instance of Inactive Customer
var inactiveCustomer =
    new InactiveCustomer("MyManMac", Gender.Male, "Pen and Paper", 31)
    {
        Reason = InactiveCustomer.InactiveReason.Hatred
    };
inactiveCustomer.SayThanks();
inactiveCustomer.SendInactiveMessage();
inactiveCustomer.PrintCustomerInfo();




public class customer2
{
    public Customer2(string name2, Gender gender2, string purchases2, DateTime.month lastpurchasedate)
    {
        Name2 = name2;
        Gender2 = gender2;
        Purchases2 = purchases2;
        LastPurchaseDate = lastpurchasedate
    }
}