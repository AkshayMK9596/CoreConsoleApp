//Do mapping of Stud type with other name (Alias)
using std = Student;
using integer = System.Int32;
class Class2
{
    static void Main(string[] args)
    {
        //Value types ==> Builtin
        int a = 10;
        Int32 b = 20;
        long c = 30;
        Int64 d = 40;

        float e = 12.34F;
        Single f = 12.23F;

        double g = 12.34;
        Double h = 12.34;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(g);
        Console.WriteLine(h);

        Student stud;
        stud.roll = 100;
        stud.name = "Rajesh";
        stud.per = 45.67;

        Console.WriteLine(stud.roll);
        Console.WriteLine(stud.name);
        Console.WriteLine(stud.per);

        std stud2;

        stud2.roll = 100;
        stud2.name = "Rajesh";
        stud2.per = 45.67;

        Console.WriteLine(stud2.roll);
        Console.WriteLine(stud2.name);
        Console.WriteLine(stud2.per);

        integer x = 100;
        Console.WriteLine(x);

    }
}
struct Student //User defined Value Types
{
    public int roll;
    public string name;
    public double per;
}