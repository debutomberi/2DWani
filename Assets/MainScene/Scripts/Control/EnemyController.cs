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
        speed = Random.Range(0.5f,1f);
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

    private void EnemyMove()
    {
        //魚の動き 
        transform.position += transform.right * speed;
        if (time > width)
        {
            if (switching2 == true)
            { 
                if (switching == true)
                {
                    speed = Random.Range(0.5f, 1f);
                    switching = false;
                }
                else
                {
                    speed = Random.Range(-0.5f, -1f);
                    switching = true;
                }
            }

            if (switching3 == true)
            { 
                if (switching == true)
                {
                    speed = Random.Range(-0.5f, -1f);
                    switching = false;
                }
                else
                {
                    speed = Random.Range(0.5f, 1f);
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
