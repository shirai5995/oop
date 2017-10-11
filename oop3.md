# 第３段階

名前、年齢のデータをprivateにする。（カプセル化）  
ゲッターを定義する。  
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
class ex
{
    static void Main()
    {
        Metro mt = new Metro("SUZUKI", 20);
        Console.Write("NAME {0}, AGE {1}, SAL {2}\n",
                mt.getname(), mt.getage(), mt.salary());
    }
}
```
