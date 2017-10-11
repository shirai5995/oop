# 第４段階

SI事業部はボーナスがでる。ボーナスは給与＊２  
SIクラスをMetroクラスの派生クラスで定義。  
（派生クラス、継承）  
※インスタンスはSIクラス型で生成  
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
    { }
    public int bon()
    {
        return salary() * 2;
    }
}
class ex
{
    static void Main()
    {
        SI mt = new SI();

        Console.Write("NAME {0}, AGE {1}, SAL {2}, BON {3}\n",
            mt.getname(), mt.getage(), mt.salary(), mt.bon());
    }
}
```
