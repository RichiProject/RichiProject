using UnityEngine;
using System.Collections;




public class Main : MonoBehaviour {


	public CameraPlayerFollow follower;
	public PlayerMovement player;


	void FixedUpdate ()
	{
		
		follower.CameraFollower ();
		player.CharacterControl ();


	}

}