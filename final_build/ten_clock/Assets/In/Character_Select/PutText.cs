using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PutText : MonoBehaviour {

	public Text charat1;

	public Text charat2;

	public Text playerLev;
	
	void Start () 
	{
		if(PlayerPrefs.GetInt("OpenCharacter") == 1) //격투가 열렸으면
        {
			charat1.text = "LV  " + PlayerPrefs.GetInt("Character1").ToString();
			charat2.text = "LV  " + PlayerPrefs.GetInt("Character2").ToString();
		}
		else
		{
			charat1.text =  "LV   " + PlayerPrefs.GetInt("Character1").ToString();
		}

		playerLev.text = "TOTAL LEVEL     :     " + PlayerPrefs.GetInt("PlayerLevel").ToString();
	}
}
