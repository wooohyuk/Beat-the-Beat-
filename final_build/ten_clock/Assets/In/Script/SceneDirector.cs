using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDirector : MonoBehaviour
{
    public UnityEngine.UI.Image fade;
    float fades = 0.0f;
    float time = 0;
    int Return_int = 0;
    int Character_int = 0;
    int Option_int = 0;
    int Ingame_int = 0;
    
    public void Return()
    {
        Return_int = 1;
    }

    public void Character()
    {
        Character_int = 1;

    }

    public void Option()
    {
        Option_int = 1;

    }

    public void Touch_Start()
    {
        Ingame_int = 1;

    }

    void Start()
    {
        fade.enabled = false;
    }

    void Update()
    {
        if (Return_int == 1)
        {
            fade.enabled = true;
            time += Time.deltaTime;
            if (fades < 1.0f && time >= 0.03f)
            {
                fades += 0.05f;
                fade.color = new Color(0, 0, 0, fades);
                time = 0;
            }
            else if (fades >= 1.0f)
            {
                SceneManager.LoadScene("2_0_Main_Menu");
                time = 0;
            }
        }

        if (Character_int == 1)
        {
            fade.enabled = true;
            time += Time.deltaTime;
            if (fades < 1.0f && time >= 0.03f)
            {
                fades += 0.05f;
                fade.color = new Color(0, 0, 0, fades);
                time = 0;
            }
            else if (fades >= 1.0f)
            {
                SceneManager.LoadScene("2_2_Character_Select");
                time = 0;
            }
        }

        if (Option_int == 1)
        {
            fade.enabled = true;
            time += Time.deltaTime;
            if (fades < 1.0f && time >= 0.03f)
            {
                fades += 0.05f;
                fade.color = new Color(0, 0, 0, fades);
                time = 0;
            }
            else if (fades >= 1.0f)
            {
                SceneManager.LoadScene("2_5_Option");
                time = 0;
            }

        }
        if (Ingame_int == 1)
        {
            fade.enabled = true;
            time += Time.deltaTime;
            if (fades < 1.0f && time >= 0.03f)
            {
                fades += 0.05f;
                fade.color = new Color(0, 0, 0, fades);
                time = 0;
            }
            else if (fades >= 1.0f)
            {
                SceneManager.LoadScene("3_Loding");
                time = 0;
            }
        }
    }
}