# 第１段階

メトロ社員の名前、年齢、給与計算を行うクラスを作る。  
給与は年齢＊１００００円である  
クラスの属性として、名前、年齢のデータ、給与計算メソッドを持つ。  
    
> Mainをもつクラスを作りMainを実装する
<br>
<br>
<br>
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
    public int salary()
    {
        return this.age * 10000;
    }
 }
 class ex
 {
    static void Main()
    {
        Metro mt = new Metro();
        Console.Write("NAME {0}, AGE {1}, SAL {2}\n",
                        mt.name, mt.age, mt.salary());
    }
 }
```
