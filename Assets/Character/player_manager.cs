using UnityEngine;
using System.Collections;

public class player_manager : MonoBehaviour {
    public float speed;
    public bool onground;

    public float left_lane = -0.5F, middle_lane = 0.5F, right_lane = 1.5F,current_pos= 1.5F;
    public float jump_force = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButton("Horizontal"))
        {
            transform.Translate(new Vector3(0, 0, speed * Input.GetAxis("Horizontal")) * Time.deltaTime);

        }
        //if (Input.GetButtonDown("Vertical") && ( -2 < rigidbody.position.z + Mathf.Sign(Input.GetAxis("Vertical")))  && ( 2 > rigidbody.position.z + Mathf.Sign(Input.GetAxis("Vertical"))))
        //{
           // transform.Translate(new Vector3(0, 0,  Input.GetAxis("Vertical")));
            //transform.Translate(new Vector3(0, 0, speed * Input.GetAxis("Vertical")) * Time.deltaTime);
         //   rigidbody.MovePosition(rigidbody.position + new Vector3(0,0,2*Mathf.Sign(Input.GetAxis("Vertical"))));
       // }
        if(Input.GetButtonDown("Vertical"))
        {
            if(Mathf.Sign(Input.GetAxis("Vertical"))==-1)
            {
                if(current_pos==middle_lane)
                {
                    current_pos = right_lane;
                }
                else if(current_pos==left_lane)
                {
                    current_pos = middle_lane;
                }
            }
            else if (Mathf.Sign(Input.GetAxis("Vertical"))==1)
            {
                if(current_pos == right_lane)
                {
                    current_pos = middle_lane;
                }
                else if(current_pos == middle_lane)
                {
                    current_pos = left_lane;
                }
            }
            transform.position = new Vector3(current_pos, transform.position.y, transform.position.z);
        }
        if(Input.GetButton("Jump")&& onground)
        {
            rigidbody.AddForce(Vector3.up * jump_force,ForceMode.Impulse);
          //  transform.Translate(Vector3.up * Time.deltaTime);
        }
	}
    void OnCollisionEnter ()
    {
        onground = true;
    }
    void OnCollisionExit ()
    {
        onground = false;
    }
}
