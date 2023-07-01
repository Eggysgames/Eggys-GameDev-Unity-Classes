using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SavingToMake : MonoBehaviour {

		//Delete Saving Data
		PlayerPrefs.DeleteAll();
		
		//Retreive Saved Data
		MyVariable = PlayerPrefs.GetInt ("MyVariables");

		//Set a saved variable
		PlayerPrefs.SetInt ("MyVariable", DataToSaveInIt);

		//Set and Retreive Bool 
		PlayerPrefs.SetInt ("MyVariable", (MyVariable ? 1 : 0));
		czpurchased = (PlayerPrefs.GetInt ("MyVariable") != 0);

}
