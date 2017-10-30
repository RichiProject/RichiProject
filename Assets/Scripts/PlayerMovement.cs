using UnityEngine;
using System.Collections;

//using UnityEngine.Math;
public class PlayerMovement : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	private float angle;
	private float speed = 0.0f;
	public float h = 0.0f;
	public float v = 0.0f;
	public JoyStick joystick;
	private int test;
	Vector3 charaPos;
	private bool charaRight = true;
	private bool charaFront = true;
	public float player_speed;
	public Component[] spriteRenderes;
	// Character Controller
	public void CharacterControl ()
	{
		
		spriteRenderes =GetComponentsInChildren<SpriteRenderer>();
		foreach (SpriteRenderer renderer in spriteRenderes) {
			renderer.sortingOrder  = Mathf.RoundToInt(transform.position.y*-100) ;
		}
		 

			
		if (animator) {

			h = joystick.Horizontal ();
			v = joystick.Vertical ();

			if (h > 0) {
				this.GetComponent<Transform> ().rotation = Quaternion.Euler (0, 0, 0);
				charaRight = true;
			} else if (h <0) {
				this.GetComponent<Transform> ().rotation = Quaternion.Euler (0, 180, 0);
				charaRight = false;
			}


			speed = new Vector2 (h, v).sqrMagnitude;


			if (speed > 0.0f) {
				if (v > 0) {
					this.GetComponent<Animator> ().SetBool ("idleDownt", false);
					this.GetComponent<Animator> ().SetBool ("runDownt", false);
					this.GetComponent<Animator> ().SetBool ("runUpt", true);
					charaFront = false;
					charaPos.x = charaPos.x + (h * 0.020f);
					charaPos.y = charaPos.y + (v * 0.020f);
//					this.GetComponent<Transform> ().position = new Vector3 (charaPos.x, charaPos.y, 0);
					//GetComponent<Rigidbody2D>().position = new Vector3 (charaPos.x, charaPos.y, 0);
					GetComponent<Rigidbody2D>().velocity = new Vector2 (h*player_speed, v*player_speed);
				}
				if (v < 0) {
					this.GetComponent<Animator> ().SetBool ("idleUpt", false);
					this.GetComponent<Animator> ().SetBool ("runUpt", false);
					this.GetComponent<Animator> ().SetBool ("runDownt", true);
					charaFront = true;
					charaPos.x = charaPos.x + (h * 0.0020f);
					charaPos.y = charaPos.y + (v * 0.0020f);
//					this.GetComponent<Transform> ().position = new Vector3 (charaPos.x, charaPos.y, 0);
					GetComponent<Rigidbody2D>().velocity = new Vector2 (h*player_speed, v*player_speed);
				}
			} else if (speed <= 0.1f) {
				this.GetComponent<Animator> ().SetBool ("runDownt", false);
				this.GetComponent<Animator> ().SetBool ("runUpt", false);

				if (charaFront == true) {
					this.GetComponent<Animator> ().SetBool ("idleDownt", true);
					this.GetComponent<Animator> ().SetBool ("idleUpt", false);
				} else {
					this.GetComponent<Animator> ().SetBool ("idleDownt", false);
					this.GetComponent<Animator> ().SetBool ("idleUpt", true);

				}

				if (charaRight == true) {
					this.GetComponent<Transform> ().rotation = Quaternion.Euler (0, 0, 0);
				} else {
					this.GetComponent<Transform> ().rotation = Quaternion.Euler (0, 180, 0);
				}
			}

		

			animator.SetFloat ("speed", speed);
		

		}
	}







}

