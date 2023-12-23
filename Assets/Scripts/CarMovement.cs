using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed = 10;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(0,0,speed*Time.deltaTime);
        }
		if (Input.GetKey(KeyCode.D))
		{
			rigidbody.AddForce(0, 0, -speed * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.W))
		{
			rigidbody.AddForce(speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(KeyCode.S))
		{
			rigidbody.AddForce(-speed * Time.deltaTime, 0, 0);
		}
	}
}
