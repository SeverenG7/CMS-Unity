using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotor : MonoBehaviour {

    public GameObject GameObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, 0, -1);
            GameObject.transform.Rotate(0, -1, 0);
        }
	}
}
