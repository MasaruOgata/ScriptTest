using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss {
    private int hp = 100;       //体力
    private int power = 25;     //攻撃力
    private int mp = 53;         //魔力

    //攻撃用の関数
    public void Attack(){
        Debug.Log(this.power + "のダメージを与えた");
    } 

    //防御用の関数
    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }

    //魔法攻撃用の関数
    public void Magic() {
        if(mp > 5) {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else {
            Debug.Log("MPが足りないため魔法攻撃が使えない");
        }
    }

}

public class Test : MonoBehaviour {

    void Start() {
        Debug.Log("Lesson4 課題 要素の個数が5の配列を順と逆順で表示");

        //要素5の任意な配列の初期化
        int[] array = { 15, 45, 30, 85, 90 };

        //for文を使って配列を順に表示
        for(int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);
        }
     
        //for文を使って配列を逆順に表示
        for(int j = array.Length; j > 0; j--) {
            Debug.Log(array[j-1]);
        }

        //以下Bossクラスを利用
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法攻撃用の関数を11回呼び出す
        for (int k = 0; k < 11; k++) {
            lastboss.Magic();
        }
    }
	

	void Update () {
		
	}
}
