using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logo_Fade : MonoBehaviour
{
    public UnityEngine.UI.Image fade;
    float fades = 1.0f;
    float time = 0;

    int exe_b = 0;

    Fade_Out fadeout;

    // Use this for initialization
    void Start()
    {
        Screen.SetResolution(1920, 1080, true);
    }


    // Update is called once per frame
    void Update()
    {
        if (exe_b == 0)
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

                exe_b = 1;
                time = 0;
            }
        }
        if (exe_b == 1)
        {
            time += Time.deltaTime;
            if (time >= 1f)
            {
                exe_b = 2;
                time = 0;
            }
        }
        if (exe_b == 2)
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
                exe_b = 3;
                time = 0;
            }
        }
        if (exe_b == 3)
        {
            SceneManager.LoadScene("0_2_Start_Logo");
        }
        }
}
