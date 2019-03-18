﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    [SerializeField]
    GameObject[] fish;
    [SerializeField]
    GameObject canvas;

    int i;
    int objCount;

    void Update()
    {
        i = Random.Range(0, 2);
        objCount = transform.childCount;

        //魚が盤面の上限を決める
        if (objCount < 8)
        {
            Move();
        }
    }

    /// <summary>
    /// 魚をランダムに出現させる
    /// </summary>
    private void Move()
    {
        GameObject enemy = Instantiate(fish[i]) as GameObject;
        int px = Random.Range(-2, 5);
        int py = Random.Range(-3, 5);
        enemy.transform.SetParent(canvas.transform, false);
        enemy.transform.position = new Vector2(px, py);
    }
}
