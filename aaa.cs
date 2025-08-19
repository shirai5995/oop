using System;
abstract class Metro
{
    private String name;
    private int age;

    public Metro()
    {
        this.name = "shirai";
        this.age = 49;
    }
    public Metro(String n, int a)
    {
        this.name = n;
        this.age = a;
    }
    public String getname(){ return name; }
    public int getage(){ return age; }
    public abstract int salary();
}

class SI : Metro
{
    public SI()
    {  }
    public SI(String n, int a) : base(n, a)
    {  }
    public override int salary()
    {
        return getage() * 8000;
    }
}
class OS : Metro
{
    public OS()
    {  }
    public OS(String n, int a) : base(n, a)
    {  }
    public override int salary()
    {
        return getage() * 12000;
    }
}

class ex
{
    static void Main()
    {
        Metro mt1 = new SI("SI_SUZUKI", 25);
        Metro mt2 = new OS("OS_SUZUKI", 25);
        Console.Write("NAME {0}, AGE {1}, SAL {2}\n",
            mt1.getname(), mt1.getage(), mt1.salary());
        Console.Write("NAME {0}, AGE {1}, SAL {2}\n",
            mt2.getname(), mt2.getage(), mt2.salary());
    }
}
