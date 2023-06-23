using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        // 配列の要素をすべて表示する
        for (int i = 0; i < array.Length; i++)
        { 
            Debug.Log(array[i]);
        }

        // 配列の要素を逆順表示する
        for (int i = array.Length - 1; i >= 0; i--)
        { 
            Debug.Log(array[i]);
        }

        Boss boss = new Boss();

        // 10回繰り返す
        for (int mp = 0; mp < 11; mp++) 
        {
            // magic関数を呼び出して繰り返す
            boss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {}

    public class Boss
    {
        int mp = 53;
        public void Magic()
        {

            if (mp >= 5)
            {
                // mpが5以上だった場合5減らす
                mp -= 5;
                Debug.Log("魔法攻撃をした。残り" + this.mp);
            }

            else
            {
                // mpが足りない時
                Debug.Log("mpが足りないため、魔法が使えない。");
            }

        }
    }
}
