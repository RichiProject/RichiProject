using UnityEngine;
using System.Collections;

//using UnityEngine.Math;
public class PlayerMovement : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	private float angle;
	private float speed = 0.0f;
	private float h = 0.0f;
	private float v = 0.0f;
	public JoyStick joystick;
	public CameraPlayerFollow follower;
	private int test;
	Vector3 charaPos;
	void Start ()
	{
		

	}



	// Update is called once per frame
	void FixedUpdate ()
	{

			CharacterControl ();
			follower.CameraFollower ();
		

	}




	// Character Controller
	void CharacterControl ()
	{
		if (animator) {

			h = joystick.Horizontal ();
			v = joystick.Vertical ();

			if (h > 0) {
				this.GetComponent<Transform> ().rotation = Quaternion.Euler (0, 0, 0);
			} else {
				this.GetComponent<Transform> ().rotation = Quaternion.Euler (0, 180, 0);
			}

			speed = new Vector2 (h, v).sqrMagnitude;


			if (speed > 0.1f) {
				this.GetComponent<Animator> ().SetBool ("run", true);
		
				charaPos.x = charaPos.x + (h*0.05f);
				//print (charaPos.x);
				charaPos.y = charaPos.y + (v*0.05f);
				this.GetComponent<Transform> ().position = new Vector3 (charaPos.x, charaPos.y, 0);
			}else if(speed < 0.1f){
				this.GetComponent<Animator> ().SetBool ("run", false);
			}

		

			animator.SetFloat ("speed", speed);
		

		}
	}







}

