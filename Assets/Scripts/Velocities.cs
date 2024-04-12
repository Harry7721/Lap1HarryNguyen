using UnityEngine;
using System.Collections;

public class Velocities : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate ()
	{
        float hor = 0;
        float ver = 0;
			if (Input.GetKey ("a"))
				hor = -1;
			 if (Input.GetKey ("d"))
				hor = 1;
			if (Input.GetKey ("w"))
				ver = 1;
			 if (Input.GetKey ("s"))
				ver = -1;
			Vector3 vel = new Vector3 (hor, 0, ver);
			GetComponent<Rigidbody>().position+= vel * speed*Time.deltaTime;
			
			
		
		}
		
		}

