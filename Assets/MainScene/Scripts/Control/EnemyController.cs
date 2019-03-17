using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    float speed = 1.0f;
    float time;

	void Start ()
    {
        
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
        if (time > 2)
        {
            speed *= -1;
            time = 0;
        }
    }
}
