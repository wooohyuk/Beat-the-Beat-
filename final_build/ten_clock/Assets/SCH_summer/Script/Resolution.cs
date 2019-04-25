using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Screen.SetResolution(1920, 1080, true);
	}
	uint exit=0;
	void Update ()
	{
		
			if (Input.GetKeyUp (KeyCode.Escape)) {
				exit++;
				if (!IsInvoking ("disable_DoubleClick"))
					Invoke ("disable_DoubleClick", 2f);
			}

			if (exit == 2) {
				CancelInvoke ("disable_DoubleClick");
				Application.Quit ();
			Debug.Log ("꺼졌다이기야");
			}

		}

	void disable_DoubleClick(){
		exit = 0;
	}

}

