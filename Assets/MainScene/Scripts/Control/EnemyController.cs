using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    int width;

    float speed;
    float time = 0;

    bool switching;
    bool switching2;
    bool switching3;

    Vector2 Scale;

    void Start ()
    {
        //初期スピードの設定
        speed = Random.Range(0.03f,0.01f);
        width = Random.Range(2, 4);

        //スケールを取得
        Scale = transform.localScale;
        Enemy();
    }
	
	void Update ()
    {        
        time += Time.deltaTime;
        EnemyMove();
    }
    
    /// <summary>
    /// 魚の向きを取得
    /// </summary>
    private void Enemy()
    {
        if(Scale.x < 0)
        {
            switching2 = true;
        }
        else if(Scale.x  > 0)
        {
            switching3 = true;
            speed *= -1;
        }
    }

    /// <summary>
    /// 魚の動き
    /// </summary>
    private void EnemyMove()
    {
        transform.position += transform.right * speed;
        if (time > width)
        {
            //魚の向きが左の時
            if (switching2 == true)
            { 
                if (switching == true)
                {
                    speed = Random.Range(0.03f, 0.01f);
                    switching = false;
                }
                else
                {
                    speed = Random.Range(-0.03f, -0.01f);
                    switching = true;
                }
            }

            //魚の向きが右の時
            if (switching3 == true)
            { 
                if (switching == true)
                {
                    speed = Random.Range(-0.03f, -0.01f);
                    switching = false;
                }
                else
                {
                    speed = Random.Range(0.03f, 0.01f);
                    switching = true;
                }
            }
                      
            width = Random.Range(2, 4);
            Scale.x *= -1;
            time = 0;            
        }
        transform.localScale = Scale;
    }
}
