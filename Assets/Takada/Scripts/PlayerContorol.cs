using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorol : MonoBehaviour {

    // 速度
    float speed = 0.05f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // 移動処理
        Move();

	}

    // 移動関数
    void Move()
    {
        var inputX = Input.GetAxisRaw("Horizontal");
        var inputY = Input.GetAxisRaw("Vertical");

        this.transform.position += new Vector3(inputX * speed, inputY * speed, 0);
    }
}
