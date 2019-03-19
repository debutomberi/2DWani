using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// プレイヤーを上下左右に移動させる。向きの判定も行う。
public class PlayerContorol : MonoBehaviour {

    // 速度
    float speed = 0.1f;
	
	// Update is called once per frame
	void Update () {

        // 移動処理
        Move();

	}

    // 移動関数
    void Move() {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        this.transform.position += new Vector3(inputX * speed, inputY * speed, 0);

        Vector3 scale = transform.localScale;

        // 右に進むときは右向きに、左に進むときは左向きに
        if(inputX <= 0) {

            scale.x = 1;


        } else {

            scale.x = -1;

        }

        // 代入し直す
        transform.localScale = scale;
        // Debug.Log(scale);

    }

    // 口の中の中の魚の分だけスピードを下げる
    void SpeedDown()
    {
        float childCount = WaniBite.fishCount; // 子オブジェクトの数を取得
        float bobSpeed = childCount * 0.001f;　// 重さ
        speed = speed - bobSpeed;              
    }
}
