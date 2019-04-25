using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade_Out : MonoBehaviour {
    public UnityEngine.UI.Image fade;
    float fades = 0.0f;
    float time = 0;
    int exe_a = 0;
    public int AnothorScene = 0;
    

	// Use this for initialization
	void Start () {
        Screen.SetResolution(1920, 1080, true);
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetMouseButton(0))
            {
               
                exe_a = 1;
            }
      
        if (exe_a == 1)
        {
            time += Time.deltaTime;
            if (fades < 1.0f && time >= 0.03f)
            {
                fades += 0.05f;
                fade.color = new Color(0, 0, 0, fades);
                time = 0;
            }
            else if (fades >= 1.0f)
            {
                AnothorScene = 1;
                SceneManager.LoadScene("2_0_Main_Menu");
                time = 0;
            }
        }
    }
}
