# 最終課題２
## トランプのカードを管理するクラスを作る

出来る操作は、
1. カードのシャッフル
1. カード1枚を配る

以下の作業を行う。
* クラス図を書く
* プログラム（クラス）を記述する
* メインプログラムを記述する
* コンパイルする
* 実行する
<br>
※メインプログラムは、カードをシャッフルし、全カードを1枚づつ配りながら内容を表示する。
<br>
<br>
<br>
<br>

```
using System;

class Card
{
    private int no;         // 番号
    private int kind;       // カード種類
    private String mark;    // マークの文字列

    private String[] mark_data = { "スペード", "クラブ", "ハート", "ダイヤ" };

    public Card(int n, int k)
    {
        this.no = n;
        this.kind = k;
        this.mark = mark_data[k];
    }

    public int getno() { return this.no; }
    public int getkind() { return this.kind; }
    public String getmark() { return this.mark; }
}

class CardDealer
{
    public const int CARD_NUM = 52;             // カードの総枚数
    private Card[] deck = new Card[CARD_NUM];   // ストックされるカード
    private int dist;                           // どこまで配ったか

    public CardDealer()
    {
        dist = CARD_NUM;
        for (int i = 0; i < CARD_NUM; i++)
            this.deck[i] = new Card(i % 13 + 1, i / 13);
    }

    public void Shuffle()
    {
        Random r = new Random();
        for (int i = 0; i < dist; i++) {
            Card work;
            int n = r.Next(dist);
            work = deck[i];
            deck[i] = deck[n];
            deck[n] = work;
        }
    }

    public Card GetCard()
    {
        if (dist <= 0)
            return null;
        return deck[--dist];
    }
}

class Sample
{
    static void Main()
    {
        CardDealer dealer = new CardDealer();

        dealer.Shuffle();       // シャッフルする

        Card c;
        while ((c = dealer.GetCard()) != null) { // 1枚もらう
            Console.Write("{0} {1}\n", c.getmark(), c.getno());
        }
    }
}
```
