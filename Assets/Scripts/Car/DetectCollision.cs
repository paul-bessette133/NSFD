using UnityEngine;
using System.Collections;

public class DetectCollision : MonoBehaviour {
	
	bool collided = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate()
	{
		if(collided)
		{
			GlobalVars.speed += 0.005f;
			
			if(GlobalVars.speed >= 0.5)
			{
				collided = false;
			}
		}
	}
	
	void OnTriggerEnter(Collider c)
	{
		if(c.tag == "obstacle")
		{
			Debug.Log("Collided");
			collided = true;
			GlobalVars.speed = 0.1f;
		}
	}
}
