﻿using System.Collections;
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

        // 飲み込む処理
        Swallow();
	}

    // 飲み込む関数
    void Swallow() {

        // 魚を含んでいる時に飲み込むボタンを押すとカウントを0にしてスコア加算
        if (fishCount >= 1) {

            if (Input.GetButton("swallow")) {

                fishCount = 0;
                Debug.Log("ごっくん！");

            }
        }

    }

    private void OnTriggerEnter2D(Collider2D col) {

        // 魚が顎に触れたら魚を消してfishCountを＋１
        if(col.tag == "Fish") {

            fishCount += 1;

            Debug.Log(fishCount);

        }
        

    }
}
