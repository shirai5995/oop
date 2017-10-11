# 第６段階

OS事業部は特例で、年齢＊１２０００円  
（メソッドのオーバーライド）  
※ボーナスは無し  
※インスタンスはMetroクラス型で生成  
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
    public virtual int salary()
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
```
