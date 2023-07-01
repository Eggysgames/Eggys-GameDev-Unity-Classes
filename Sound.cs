using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {


	public AudioSource soundplayer;
	public AudioClip glocksound;
	public float myrandom;


    //Be aware that sound won't play if timescale is 0 with the below ones

    //Much easier option spawns a sound at a point and all you need is the audioClip dragged in
    AudioSource.PlayClipAtPoint(explosionsound, Camera.main.transform.position, 100);

    //Use to make a sound on and off button
    AudioListener.pause == true
     
    //Set clip and play through source. Use this for buttons in pause menu's.
	soundplayermusic.clip = infestationmusic;
	soundplayermusic.Play();     
        

	//Play a single sound directly from source. Must set the audioclip first.
	glocksound.Play (); 

	///Play audio clips through the source only once
	soundplayer.PlayOneShot (glocksound, 0.7f); 

	//Changing sounds pitch
	myrandom = Random.Range (0.5f, 1.5f);
	glocksound.pitch = myrandom;
	glocksound.Play ();

	//Play a sound at a location
	AudioSource.PlayClipAtPoint (bigbangsound, mypos.transform.position);

}
