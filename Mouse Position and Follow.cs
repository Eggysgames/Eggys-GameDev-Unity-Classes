using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour {


	void Update () {


		//Follows Mouse
		//Set it to Mouse Position. Change Z to custom. Convert to screen when setting.
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 10; 
		transform.position = Camera.main.ScreenToWorldPoint (mousePos);
		Debug.Log (Camera.main.ScreenToWorldPoint (mousePos));




	}
}
