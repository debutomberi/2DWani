using System.Collections;
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
        i = Random.Range(0, 3);
        objCount = transform.childCount;

        //魚が盤面の上限を決める
        if (objCount < 16)
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
        float px = Random.Range(-15f, 15f);
        float py = Random.Range(-8.0f, 8.0f);
        enemy.transform.SetParent(canvas.transform, false);
        enemy.transform.position = new Vector2(px, py);
    } 
}
