﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager> {

    //Scoreの収納
    int score;

    public int Score { get { return score; } }

    private void Start(){
        DontDestroyOnLoad(this.gameObject);
    }

    //スコアの加算式
    public void ScorePlus(int enemyCount) {
        double i = 100 * (1 + (enemyCount * 0.2));
        score += (int)i;
    }

    public void ScoreReset() {
        score = 0;
    }

}