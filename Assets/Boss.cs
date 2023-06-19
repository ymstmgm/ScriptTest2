using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    int mp = 53;
    public void magic()
    { 
        if (mp >= 5)
        {
            // mpが5以上だった場合5減らす
            mp -= 5;
            Debug.Log("魔法攻撃をした。残り48。");
        }

        else
        {
            // mpが足りない時
            Debug.Log("mpが足りないため、魔法が使えない。。");

        }
     }


 public class Test : MonoBehaviour
  {
        // Start is called before the first frame update
        void start ()

        {
            Boss lastboss = new Boss();

             // 10回繰り返す
             for (int mp = 0; mp < 11; mp++) ;
             Debug.Log("mpが足りない。");

            // magic関数を呼び出す
            lastboss.magic();
        }
   }
}
