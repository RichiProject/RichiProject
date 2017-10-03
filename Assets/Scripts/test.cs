using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class test : MonoBehaviour,IDragHandler,IPointerUpHandler,IPointerDownHandler
{



	public virtual void OnDrag(PointerEventData ped)
	{

		print ("onDrag");
	}	
	public virtual void OnPointerDown(PointerEventData ped)
	{
		
		print ("onPointerDown");
	}
	public virtual void OnPointerUp(PointerEventData ped)
	{
		print ("onPointerUp");

	}

}