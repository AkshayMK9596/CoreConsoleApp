class Class3
{
    static void Main(string[] args)
    {

        //Reference Types => Class types
        string s = "hello";
        String z = "hello";

        object x = 100;
        x = 12.34;
        x = false;
        x = "hello";

        Console.WriteLine(s);
        Console.WriteLine(z);
        Console.WriteLine(x);

        int[] a = {10,20,30,40 };  //type (integer array)   object

        for(int i=0;i<4;i++)
        {
            Console.WriteLine(a[i]);
        }
        foreach(int v in a)
        {
            Console.WriteLine(v);
        }

        //Customer cust=new Customer();
        Customer cust = new();
        cust.id = 100;
        cust.name = "Rajesh";
        cust.address = "Karad";
        Console.WriteLine(cust.id);
        Console.WriteLine(cust.name);
        Console.WriteLine(cust.address);

        Customer cust2 = new Customer() { id = 120, name = "Suresh", address = "satara" };
        Console.WriteLine(cust2.id);
        Console.WriteLine(cust2.name);
        Console.WriteLine(cust2.address);
    }
}
class Customer
{
    public int id;
    public string name;
    public string address;
}