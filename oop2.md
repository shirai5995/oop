# 第２段階

名前、年齢をコンストラクタで指定できるようにする。  
（コンストラクタのオーバーロード）
br
br
```
using System;
class Metro
{
    public String name;
    public int  age;

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
    public int salary()
    {
        return this.age * 10000;
    }
}
class ex
{
    static void Main()
    {
        Metro mt = new Metro("SUZUKI", 20);

        Console.Write("NAME {0}, AGE {1}, SAL {2}\n",
                        mt.name, mt.age, mt.salary());
    }
}
```
