using UnityEngine;
using System.Collections;

public class Moving_y : MonoBehaviour {

	public float speed;
	public float up_limit;
	public float down_limit;
	private bool go_up = true;
	// Update is called once per frame
	void Update () 
	{
		if ((transform.position.y <= down_limit) || (transform.position.y >= up_limit)) 
		{
			if (transform.position.y <= down_limit) 
			{
				go_up = true;
			} 
			else 
			{
				go_up = false;
			}
		}
		if (go_up) 
		{
			transform.Translate (new Vector3 (0.0F, speed, 0.0F));
			go_up = true;
		} 
		else 
		{
			transform.Translate (new Vector3 (0.0F, -speed, 0.0F));
			go_up = false;
		}
	}
}
