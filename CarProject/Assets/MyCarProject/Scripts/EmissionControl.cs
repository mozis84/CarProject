using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionControl : MonoBehaviour {

   public Material material;

	// Use this for initialization
	void Start () {


        


    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("i"))
        {
            material.EnableKeyword("_EMISSION");

        }


        if (Input.GetKeyDown("o"))
        {
            material.DisableKeyword("_EMISSION");

        }

    }
}
