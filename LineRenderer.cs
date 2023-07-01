using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {


    public GameObject lasernode1;
    public GameObject lasernode2;

    private LineRenderer laserLine;

    void Start() {

        laserLine = GameObject.Find("UICanvasNonChange").GetComponent<LineRenderer>();
        laserLine.enabled = true;

    }


    void Update() {

        
        laserLine.SetPosition(0, lasernode1.transform.position);
        laserLine.SetPosition(1, lasernode2.transform.position);

        

    }



}
