using UnityEngine;
using System.Collections;

public class AutoMove : MonoBehaviour {	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate()
	{
		gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0.44f, gameObject.transform.position.z + GlobalVars.speed);
	}
}
