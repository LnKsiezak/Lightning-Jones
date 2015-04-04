using UnityEngine;
using System.Collections;

public class Moving_z : MonoBehaviour {

	public float speed;
	public float front_limit;
	public float rear_limit;
	private bool go_rear = true;
	
	// Update is called once per frame
	void Update () 
	{
		if ((transform.position.z <= front_limit) || (transform.position.z >= rear_limit)) 
		{
			if (transform.position.z <= front_limit) 
			{
				go_rear = true;
			} 
			else 
			{
				go_rear = false;
			}
		}
		if (go_rear) 
		{
			transform.Translate (new Vector3 (0.0F, 0.0F, speed));
			go_rear = true;
		} 
		else 
		{
			transform.Translate (new Vector3 (0.0F, 0.0F, -speed));
			go_rear = false;
		}
	
	}
}
