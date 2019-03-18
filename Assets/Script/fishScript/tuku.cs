using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuku : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D col)
    {
        Rigidbody2D rd = gameObject.GetComponent<Rigidbody2D>();
        rd.isKinematic = false;
        Debug.Log("sasa");
    }
}
