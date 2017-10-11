# 第５段階

SIクラスに引数指定のコンストラクタと、イニシャライザーを定義  
<br>
<br>
```
using System;
class Metro
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
    public int salary()
    {
        return this.age * 10000;
    }
}
class SI : Metro
{
    public SI()
    {  }
    public SI(String n, int a) : base(n, a)
    {  }
    public int bon()
    {
        return salary() * 2;
    }
}
class ex
{
    static void Main()
    {
        SI mt = new SI("SUZUKI", 25);
        Console.Write("NAME {0}, AGE {1}, SAL {2}, BON {3}\n",
            mt.getname(), mt.getage(), mt.salary(), mt.bon());
    }
}
```
