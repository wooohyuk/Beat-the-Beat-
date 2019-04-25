using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Seven_Fade : MonoBehaviour {
    public Image fadeIn;
    public Image fadeOut;
    float fades = 1.0f;
    float time = 0;

    public int exe_b = 0;

    Fade_Out fadeout;

    void Start()
    {
        fadeOut.enabled = false;
    }

    void Update()
    {
        if (exe_b == 0)
        {
            time += Time.deltaTime;
            if (fades > 0.0f && time >= 0.03f)
            {
                fades -= 0.05f;
                fadeIn.color = new Color(0, 0, 0, fades);
                time = 0;
            }

            else if (fades <= 0.0f)
            {
                fadeIn.enabled = false;
                exe_b = 1;
                time = 0;
                fades = 0.0f;

                StaticHome.badCount = 0;
                StaticHome.missCount = 0;
                StaticHome.goodCount = 0;
                StaticHome.perfectCount = 0;
                StaticHome.scoreCount = 0;
                StaticHome.comboCount = 0;
                GameObject.Find("GameManager").GetComponent<TxtTest>().Change_boolNote();
                GameObject.Find("MusicPlayer").GetComponent<WOO_player>().StartAudio();
            }
        }

        if (exe_b == 2)
        {
            fadeOut.enabled = true;
            time += Time.deltaTime;
            if (fades < 1.0f && time >= 0.03f)
            {
                fades += 0.005f;
                fadeOut.color = new Color(0, 0, 0, fades);
                time = 0;
            }
            else if (fades >= 1.0f)
            {
                if (StaticHome.finalScore == "F")
                {
                    SceneManager.LoadScene("5_Result_Screen_Over");
                }
                else
                {
                    SceneManager.LoadScene("5_Result_Screen_Clear");
                }
                exe_b = 3;
                time = 0;
            }
        }

    }


}


