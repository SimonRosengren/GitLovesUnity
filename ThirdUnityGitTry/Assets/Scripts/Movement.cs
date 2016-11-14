using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    Rigidbody rb;
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        rb.AddForce(new Vector3(0, 0, 1));
	}
}
