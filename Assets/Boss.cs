using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    int mp = 53;
    int magic = 53;



    public void Attack()
    {
        if (magic >= 5)
        {
            // mpが5以上だった場合5減らす
            mp -= 5;
            {
              Debug.Log("魔法攻撃をした。残り○○。");
            }

        }

        else
        {
            // mpが足りない時
            {
              Debug.Log("mpが足りない。");
            }

        }

        // Start is called before the first frame update
        
        {
            Boss lastboss = new Boss();

           {
              // 10回繰り返す
              for (int mp = 0; mp < 5; mp++) ;
           }
            {
              Debug.Log("mpが足りない。");

            }
        }
    }
}
