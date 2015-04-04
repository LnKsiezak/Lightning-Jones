using UnityEngine;
using System.Collections;

public class Moving_x : MonoBehaviour 
{	
	public float speed;
	public float left_limit;
	public float right_limit;
	private bool go_right = true;
	// Update is called once per frame
	void Update () 
	{
		if ((transform.position.x <= left_limit) || (transform.position.x >= right_limit)) 
		{
			if(transform.position.x <= left_limit)
			{
				go_right = true;
			}
			else
			{
				go_right = false;
			}
		}
		if (go_right) 
		{
			transform.Translate (new Vector3(speed,0.0F,0.0F));
			go_right = true;
		} 
		else 
		{
			transform.Translate(new Vector3(-speed,0.0F,0.0F));
			go_right = false;
		}

	}
}
