using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    [SerializeField]
    Rigidbody2D rd;
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
        StartCoroutine("Rdo");
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
    /// 魚が無限に上下する
    /// </summary>
    /// <returns></returns>
    private IEnumerator Rdo()
    {
        while (true)
        {
            yield return new WaitForSeconds(10.0f);
            rd.gravityScale *= -1;            
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

    
    private void OnTriggerEnter2D(Collider2D col)
    {
        transform.parent = col.gameObject.transform;
        switching2 = false;
        switching3 = false;
        speed = 0;
        rd.gravityScale = 0;
        Debug.Log("tata");
    }
}
