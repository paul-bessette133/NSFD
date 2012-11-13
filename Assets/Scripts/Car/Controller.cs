using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//Left
		if(Input.GetKey(KeyCode.A))
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x - Time.deltaTime,gameObject.transform.position.y,gameObject.transform.position.z);
		}
		
		//Right
		if(Input.GetKey(KeyCode.D))
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x + Time.deltaTime,gameObject.transform.position.y,gameObject.transform.position.z);
		}
	}
}
