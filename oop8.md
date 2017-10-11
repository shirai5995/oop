# 第８段階

Mainのインスタンス生成を部分を配列にして、  
動的呼び出しを体験する。  
（ダイナミックバインディング）  
<br>
<br>
```
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
        Metro [] mt = new Metro[2];
        mt[0] = new SI("SI_SUZUKI", 25);
        mt[1] = new OS("OS_SUZUKI", 25);
        for (int i = 0; i < 2; i++) {
            Console.Write("NAME {0}, AGE {1}, SAL {2}\n",
                mt[i].getname(), mt[i].getage(), mt[i].salary());
        }
    }
}
```
