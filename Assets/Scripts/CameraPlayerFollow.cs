using UnityEngine;
using System.Collections;

public class CameraPlayerFollow : MonoBehaviour
{
	
	public GameObject camera_follow;
	private Transform follow;
	private Transform targetPosition;

	// Use this for initialization
	void Start ()
	{
		//targetPosition = GameObject.FindWithTag ("Player").transform;
		targetPosition = GameObject.Find ("Character").transform;
	}

	public void CameraFollower ()
	{ 
		GetComponent<Rigidbody2D>().position = Vector3.Lerp (GetComponent<Rigidbody2D>().position, targetPosition.transform.position, 0.1f);
	}
}
