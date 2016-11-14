using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    GameObject player;
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z - 4);
	}
}
