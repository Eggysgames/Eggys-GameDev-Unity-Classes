using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldtoCameraPosition : MonoBehaviour {


	

	void Update () {

        ///1 is fully to right, 0 is fully to left. 
        ////0,0 is bottom left, 1,1 is top right
        ///use an if command to find if they are close to camera or past it
        ///
        Vector3 worldtoCameraPos = Camera.main.WorldToViewportPoint(target.transform.position);
        Debug.Log(worldtoCameraPos);

    }
}
