using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaniBite : MonoBehaviour {

    // 顎の当たり判定
    public Collider2D agoCollider;

    // 口の中に含んでいる魚の数
    public static int fishCount = 0;

	// Use this for initialization
	void Start () {

        // 当たり判定の取得
        agoCollider = GetComponent<Collider2D>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col) {

        // 魚が顎に触れたら魚を消してfishCountを＋１
        if(col.tag == "Fish") {

            fishCount += 1;
            Destroy(col.gameObject);
            // Debug.Log(fishCount);

        }

    }
}
