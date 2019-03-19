using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaniBite : MonoBehaviour {

    // 口の中に含んでいる魚の数(子オブジェクトの数)
    public static int fishCount;

    // Enemy(親オブジェクト)
    public GameObject parentObj;

    // スクリプト受け取り用変数
    ScoreManager script;


	// Use this for initialization
	void Start () {

        // scriptを変数に格納
        script = GetComponent<ScoreManager>();

    }
	
	// Update is called once per frame
	void Update () {

        // 飲み込む処理
        Swallow();

        //子要素を数える処理
        ChildCount();

    }

    // 飲み込む関数
    void Swallow() {

        // 魚を含んでいる時に飲み込むボタンを押すとカウントを0にして敵も消す。
        if (fishCount >= 1) {

            if (Input.GetButton("swallow")) {

                

                script.ScorePlus(fishCount);

                fishCount = 0;
                
                Debug.Log("ごっくん！");

            }
        }

    }

    // 子オブジェクトの数を数える関数
    public void ChildCount()
    {
        fishCount = parentObj.transform.childCount;
        Debug.Log(fishCount);

    }

    /*
    // 衝突処理
    private void OnTriggerEnter2D(Collider2D col)
    {
        fishCount += 1;
        Debug.Log(fishCount);
    }
    */
    

}
