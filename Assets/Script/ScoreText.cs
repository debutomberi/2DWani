using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField]
    Text scoreText;

    // Use this for initialization
    void Start()
    {
        ScoreManager.Instance.ScoreReset();
        scoreText.text = string.Format("{0:D5}", ScoreManager.Instance.Score);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = string.Format("{0:D5}", ScoreManager.Instance.Score);
    }
}
