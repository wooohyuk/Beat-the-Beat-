using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Text : MonoBehaviour {

    public UnityEngine.UI.Text Character;
    float timer; // 타이머

    // Use this for initialization
    void Start () {
        Character.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
      
        if (Arrow_Button.Pos == 2)
        {
            timer += Time.deltaTime;
            if (timer > 0.5f)
            {
                Character.enabled = true;
                timer = 0;
            }
        }
        else
        {
            Character.enabled = false;
        }

    }
}
