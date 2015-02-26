using UnityEngine;
using System.Collections;

public class player_manager : MonoBehaviour {
    public float speed;
    public bool onground;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButton("Horizontal"))
        {
            transform.Translate(new Vector3(0, 0, speed * Input.GetAxis("Horizontal")) * Time.deltaTime);

        }
        if (Input.GetButtonDown("Vertical") && ( -2 < rigidbody.position.z + Mathf.Sign(Input.GetAxis("Vertical")))  && ( 2 > rigidbody.position.z + Mathf.Sign(Input.GetAxis("Vertical"))))
        {
           // transform.Translate(new Vector3(0, 0,  Input.GetAxis("Vertical")));
            //transform.Translate(new Vector3(0, 0, speed * Input.GetAxis("Vertical")) * Time.deltaTime);
            rigidbody.MovePosition(rigidbody.position + new Vector3(0,0,2*Mathf.Sign(Input.GetAxis("Vertical"))));
        }
        if(Input.GetButton("Jump")&& onground)
        {
            rigidbody.AddForce(0,3,0,ForceMode.Impulse);
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
