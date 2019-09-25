using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {
                 
                 public GameObject piggyPlayer; //this is a reference to the player object
                 public float strength = 500;
                 public int number;
	// Use this for initialization
	void Start () {
                    
	     piggyPlayer.GetComponent<Rigidbody2D>().AddForce(new Vector2(1,1)*strength);
	}
	
	// Update is called once per frame

	void Update () {
	     Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
                     Vector3 mousePositionInWorldCoordinates = Camera.main.ScreenToWorldPoint(mousePosition);
                     Vector3 direction = mousePositionInWorldCoordinates - transform.position;





	}
}
