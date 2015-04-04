using UnityEngine;
using System.Collections;

public class Moving_x : MonoBehaviour 
{	
	public float speed = 1.0F;
	public float left_limit = 0.0F;
	public float right_limit = 1.0F;
	private bool go_right = true;
	// Update is called once per frame
	void Update () 
	{
		float movement = speed * Time.deltaTime;
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
			transform.Translate (new Vector3(movement,0.0F,0.0F));
		} 
		else 
		{
			transform.Translate(new Vector3(-movement,0.0F,0.0F));
		}

	}
}
