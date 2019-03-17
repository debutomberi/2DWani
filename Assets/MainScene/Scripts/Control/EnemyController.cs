using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    int width;

    float speed = 1.0f;
    float time = 0;
    bool switching = true;

    Vector2 Scale;

    void Start ()
    {
        width = Random.Range(2, 4);
        //スケールを取得
        Scale = transform.localScale;
    }
	
	void Update ()
    {        
        time += Time.deltaTime;
        EnemyMove();
    }
    
    private void EnemyMove()
    {        
        //魚の動き
        transform.position += transform.right * speed;       
        if (time > width)
        {
            if(switching == true)
            {
                speed = Random.Range(-0.5f, -1f);
                switching = false;
            }
            else
            {
                speed = Random.Range(0.5f, 1f);
                switching = true;
            }
                      
            width = Random.Range(2, 4);
            Scale.x *= -1;
            time = 0;            
        }
        transform.localScale = Scale;
    }
}
