using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLight : MonoBehaviour {

    public GameObject RLight;
    public GameObject LLight;
    public Transform from;
    public Transform to;
    public float turnSpeed = 50f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

         if (Input.GetKey(KeyCode.O))
          LLight.transform.Rotate(Vector3.right, turnSpeed*Time.deltaTime);

         if (Input.GetKey(KeyCode.O))
          RLight.transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);


      
    }
}
