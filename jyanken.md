# 最終課題

## ジャンケンプログラム

ジャンケンをするプログラムを作成する  
コンピュータと人間が対戦するジャンケン。  
<br>
以下の作業を行う。  
* クラス図を書く  
* プログラム（クラス）を記述する  
* メインプログラムを記述する  
* コンパイルする
* 実行する
<br>
<br>
また、ジャンケンに参加するには、以下のクラスから派生された
プレーヤーであること。

```
// プレーヤークラス（抽象クラス）
abstract class Player
{
    private String name;
    public String getname() { return this.name; }
    public Player(String str)
    {
        this.name = str;
    }
    public abstract int pon();
}
```

**Jankenクラス**を必ず作る。  
また実行開始用のrun()メソッドも必須。  
メインからは以下のように呼び出し、ジャンケンを開始する。

```
class Program
{
    static void Main()
    {
        Janken j = new Janken();
        j.run();
    }
}
```
<br>
<br>
<br>
<br>
ジャンケンプログラム

```
using System;
class Program
{
    static void Main()
    {
        Janken j = new Janken();
        j.run();
    }
}

class Janken
{
    Player[] player = new Player[2];

    public Janken()
    {
        player[0] = new Com();
        player[1] = new Human();
    }

    public void run()
    {
        int p1Finger;
        int p2Finger;
        int win;

        Console.WriteLine("ジャンケン・・ポン！");
        while (true)
        {
            p1Finger = player[0].pon();
            p2Finger = player[1].pon();
            Console.Write("\n{0}: {1}\n", player[0].getname(), showFinger(p1Finger));
            Console.Write("{0}: {1}\n\n", player[1].getname(), showFinger(p2Finger));

            win = Judge(p1Finger, p2Finger);
            if (win != 2)
            {
                Console.WriteLine("勝ったのは「{0}」", player[win].getname());
                break;
            }
            Console.WriteLine("あいこで・・ショ！");
        }
        return;
    }
    
    // 勝敗判定（0でp1勝ち、1でp1負け、2であいこ）
    private int Judge(int p1, int p2)
    {
        if (p1 == p2)
            return 2;
        if ((p1 == 0 && p2 == 1) || (p1 == 1 && p2 == 2) || (p1 == 2 && p2 == 0))
            return 0;
        return 1;
    }

    private String showFinger(int f)
    {
        String[] s = { "グー", "チョキ", "パー" };
        return s[f];
    }
}

abstract class Player
{
    private String name;
    public String getname() { return this.name; }

    public Player(String str)
    {
        this.name = str;
    }
    public abstract int pon();
}

class Com : Player
{
    Random r;
    public Com() : base("コンピュータ")
    {
        r = new Random();
    }

    public override int pon()
    {
        return r.Next(3);
    }
}

class Human : Player
{
    public Human() : base("あなた")
    {
    }

    public override int pon()
    {
        int num;

        while (true)
        {
            Console.Write("(グー=1, チョキ=2, パー=3)=> ");
            try {
                num = Int32.Parse(Console.ReadLine());
            }
            catch (Exception) {
                continue;
            }
            if (num >=1 && num <= 3)
                break;
        }
        return num - 1;
    }
}
```
