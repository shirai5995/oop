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

必ずJankenクラスは必ず作る。また実行開始用のrun()メソッドも必須。  
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
