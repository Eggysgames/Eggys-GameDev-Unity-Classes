using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCheck : MonoBehaviour {

    public float distancecheck;
	

	void Update () {

        ///Distance between 2 positions
        distancecheck = Vector2.Distance(transform.position, player.transform.position);

        //Move Towards a position
        this.transform.position = Vector2.MoveTowards(gameObject.transform.position, goldenegg.transform.position, Time.deltaTime * speed);

    }
}
