using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    int second = 0;
    int minute = 1;

    [SerializeField]
    Text timerText;

	// Use this for initialization
	void Start () {
        StartCoroutine(TimerCoroutine());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator TimerCoroutine() {
        bool TimeEnd = false;
        while(!TimeEnd){
            yield return new WaitForSeconds(1.0f);
            second--;
            if (second < 0) { minute--; second = 59;  }
            timerText.text = string.Format("{0:D2}",minute) + ":" + string.Format("{0:D2}", second);
            if(second == 0 && minute == 0) {
                TimeEnd = true;
                SceneManager.LoadScene("result");
            }
        }
    }
}
