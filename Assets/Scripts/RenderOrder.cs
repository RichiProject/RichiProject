using UnityEngine;
using System.Collections;

public class RenderOrder : MonoBehaviour
{
	public Component[] spriteRenderesChild;
//	public Component spriteRenderesParent;
	// Use this for initialization
//	private SpriteRenderer rencerc;

	void Start()
	{
		spriteRenderesChild = GetComponentsInChildren<SpriteRenderer> ();
		foreach (SpriteRenderer rendererc in spriteRenderesChild) {
			rendererc.sortingOrder = Mathf.RoundToInt (transform.position.y*-100);
		}
	
//		spriteRenderesParent = GetComponent<SpriteRenderer> ();
//		rencerc.sortingOrder = Mathf.RoundToInt (transform.position.y);
		 
	}
}