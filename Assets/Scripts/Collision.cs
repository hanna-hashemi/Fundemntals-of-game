using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
	[SerializeField] private GameObject[] lights;
	// Update is called once per frame
	void Update()
    {
        
    }
	private void OnCollisionEnter(UnityEngine.Collision collision)
	{
		if(collision.gameObject.tag =="Tunnel")
		{
			Light carlight= GetComponent<Light>();
			carlight.enabled = true;
		}
	}
	private void OnCollisionExit(UnityEngine.Collision collision)
	{
		if (collision.gameObject.tag == "Tunnel")
		{
			Light carlight = GetComponent<Light>();
			carlight.enabled = false;
		}
	}
}
