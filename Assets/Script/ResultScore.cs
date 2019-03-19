using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    [SerializeField]
    Text scoreText;

    // Use this for initialization
    void Start()
    {
        scoreText.text = string.Format("{0:D5}", ScoreManager.Instance.Score);
    }
    
}
