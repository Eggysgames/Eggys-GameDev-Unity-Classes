using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {

	public Texture2D cursortexture;
	public Vector2 hotspot;


	//Set Cursor through system
	Cursor.SetCursor(cursortexture, hotspot, CursorMode.ForceSoftware);


	//Manually Move an object directly onto mouse
	Vector3 mousePos = Input.mousePosition;
	mousePos.z = crosshair.transform.position.z - Camera.main.transform.position.z;
	crosshair.transform.position = Camera.main.ScreenToWorldPoint (mousePos);





}
