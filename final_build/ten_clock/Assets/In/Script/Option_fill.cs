using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option_fill : MonoBehaviour {

    public UnityEngine.UI.Image Fill;
    public UnityEngine.UI.Scrollbar Circle;
    
   
	// Update is called once per frame
	void Update () {
        Fill.fillAmount =Circle.value;
	}
}
