using UnityEngine;
using System.Collections;

public class OnTheGround : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider c)
	{
		Debug.Log ("collision");
		if(c.name == "Road")
		{
//			gameObject.GetComponent<Rigidbody>().
		}
	}
}
