using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("i"))
        {
            this.GetComponent<Light>().enabled = true;

        }


        if (Input.GetKeyDown("o"))
        {
            this.GetComponent<Light>().enabled = false;

        }

    }
}
