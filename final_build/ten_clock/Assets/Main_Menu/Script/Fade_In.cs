using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade_In : MonoBehaviour
{
    public UnityEngine.UI.Image fade;
    float fades = 1.0f;
    float time = 0;

    bool check = false;

    Fade_Out fadeout;

    // Use this for initialization
    void Start()
    {
        Screen.SetResolution(1920, 1080, true);
    }

 
    // Update is called once per frame
    void Update()
    {
        if (check == false)
        {
            time += Time.deltaTime;
            if (fades > 0.0f && time >= 0.03f)
            {
                fades -= 0.05f;
                fade.color = new Color(0, 0, 0, fades);
                time = 0;
            }

            else if (fades <= 0.0f)
            {
                fade.enabled = true;
                check = 1;
                time = 0;
            }
        }
       
    }
}
