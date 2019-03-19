using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanEat : MonoBehaviour {

	
	void Start () {
		
	}
	
	
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "FishLeft" && col.gameObject.tag == "Fish")
        {
            transform.parent = col.gameObject.transform;
            Debug.Log("koko");
        }
    }
}
