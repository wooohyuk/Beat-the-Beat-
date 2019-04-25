using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrow_Button : MonoBehaviour
{
    public UnityEngine.UI.Image Fill_amount_1;
    public UnityEngine.UI.Image Fill_amount_2;
    public Animator Pos_It;
    public Animator absabs;
    Vector3 point;
    Vector3 point2;
    public float speed = 10f; // 카메라 이동속도
    public static int Pos = 1;
    float timer; // 타이머
    float a = 0;
    int In_abs = 0;
    public UnityEngine.UI.Image fade;
    float fades = 0.0f;
    float time = 0;

    bool animCheck;
    public Animator[] anim;

    public void R_ArrowDown()
    {
        if (Pos < 5)
            Pos += 1;
        Pos_It.SetInteger("Pos_It", Pos);
        absabs.SetInteger("absabs", Pos);
    }

    public void L_ArrowDown()
    {
        if (Pos > 1)
        {
            Pos -= 1;
            Pos_It.SetInteger("Pos_It", Pos);
            absabs.SetInteger("absabs", Pos);
        }
    }

    public void touch_panel()
    {
        if (In_abs < 6)
        {
            In_abs = Pos;
        }
    }

    void Start()
    {
        animCheck = true;
        fade.enabled = false;
    }

    void Update()
    {
        if (In_abs == 1)
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
                In_abs = 0;
                SceneManager.LoadScene("2_1_Game_Start");
                time = 0;
            }

        }
        else if (In_abs == 2)
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
                In_abs = 0;
                SceneManager.LoadScene("2_2_Character_Select");
                time = 0;
            }

        }
        else if (In_abs == 3)
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
                In_abs = 0;
                SceneManager.LoadScene("2_3_Ranking");
                time = 0;
            }

        }
        else if (In_abs == 4)
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
                In_abs = 0;
                SceneManager.LoadScene("2_4_Achivement");
                time = 0;
            }

        }
        else if (In_abs == 5)
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
                In_abs = 0;
                SceneManager.LoadScene("2_5_Option");
                time = 0;
            }

        }
        switch (Pos)
        {
             case 1:
                timer += Time.deltaTime;
                if (timer > 0.0000000008f)
                {
                    if (a > 0f)
                    {
                        a -= 1f;
                        if (a < 0f)
                        {
                            if(animCheck)
                            {
                                animCheck = false;
                                ReStartAnimation();
                            }
                            a = 0;
                        }
                    }
                    transform.position = new Vector3(a, transform.position.y, transform.position.z);
                    timer = 0;
                }
                break;
            case 2:
                
                Fill_amount_1.enabled = false;
                Fill_amount_2.enabled = false;
                timer += Time.deltaTime;
                if (timer > 0.0000000008f)
                {
                    if (a < 17.76174f)
                    {
                        a += 1f;
                        if (a > 17.76174)
                        {
                            if (!animCheck)
                            {
                                animCheck = true;
                            }
                            a = 17.76174f;
                        }
                    }
                    if (a > 17.76174f)
                    {
                        a -= 1f;
                        if (a < 17.76174f)
                        {
                            if (!animCheck)
                            {
                                animCheck = true;
                            }
                            a = 17.76174f;
                        }
                    }
                    transform.position = new Vector3(a, transform.position.y, transform.position.z);
                    timer = 0;
                }
                break;
            case 3:
                Fill_amount_1.enabled = false;
                Fill_amount_2.enabled = false;
                timer += Time.deltaTime;
                if (timer > 0.0000000008f)
                {
                    if (a < 17.76174 * 2f)
                    {
                        a += 1f;
                        if (a > 17.76174 * 2f)
                        {
                            if (animCheck)
                            {
                                animCheck = false;
                                ReStartAnimation();
                            }
                            a = 17.76174f * 2f;
                        }
                    }
                    if (a > 17.76174 * 2f)
                    {
                        a -= 1f;
                        if (a < 17.76174 * 2f)
                        {
                            if (animCheck)
                            {
                                animCheck = false;
                                ReStartAnimation();
                            }
                            a = 17.76174f * 2f;
                        }
                    }
                    transform.position = new Vector3(a, transform.position.y, transform.position.z);
                    timer = 0;
                }
                break;
            case 4:
                Fill_amount_1.enabled = false;
                Fill_amount_2.enabled = false;
                timer += Time.deltaTime;
                if (timer > 0.0000000008f)
                {
                    if (a < 17.76174 * 3f)
                    {
                        a += 1f;
                        if (a > 17.76174 * 3f)
                        {
                            if (!animCheck)
                            {
                                animCheck = true;
                            }
                            a = 17.76174f * 3f;
                        }
                    }
                    if (a > 17.76174 * 3f)
                    {
                        a -= 1f;
                        if (a < 17.76174 * 3f)
                        {
                            if(!animCheck)
                            {
                                animCheck = true;
                            }
                            a = 17.76174f * 3f;
                        }
                    }
                    transform.position = new Vector3(a, transform.position.y, transform.position.z);
                    timer = 0;
                }
                break;
            case 5:
                Fill_amount_1.enabled = false;
                Fill_amount_2.enabled = false;
                timer += Time.deltaTime;
                if (timer > 0.0000000008f)
                {
                    if (a < 17.76174 * 4f)
                    {
                        a += 1f;
                        if (a > 17.76174 * 4f)
                        {
                            a = 17.76174f * 4f;
                        }
                    }
                    if (a > 17.76174 * 4f)
                    {
                        a -= 1f;
                        if (a < 17.76174 * 4f)
                        {
                            a = 17.76174f * 4f;
                        }
                    }
                    transform.position = new Vector3(a, transform.position.y, transform.position.z);
                    timer = 0;
                }
                break;
        }

    }

    void ReStartAnimation()
    {
        for(int i = 0; i < 20; i++)
        {
            if(anim[i].GetCurrentAnimatorStateInfo(0).IsName("Logo"))
            {
                anim[i].Play("Logo", -1, 0);
            }
            else if(anim[i].GetCurrentAnimatorStateInfo(0).IsName("Man"))
            {
                anim[i].Play("Man", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("Arrow_1"))
            {
                anim[i].Play("Arrow_1", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("Arrow_2"))
            {
                anim[i].Play("Arrow_2", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("Arrow_3"))
            {
                anim[i].Play("Arrow_3", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("Arrow_4"))
            {
                anim[i].Play("Arrow_4", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("Arrow_5"))
            {
                anim[i].Play("Arrow_6", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("Start_Text"))
            {
                anim[i].Play("Start_Text", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("1"))
            {
                anim[i].Play("1", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("2"))
            {
                anim[i].Play("2", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("3"))
            {
                anim[i].Play("3", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("4"))
            {
                anim[i].Play("4", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("5"))
            {
                anim[i].Play("5", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("6"))
            {
                anim[i].Play("6", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("7"))
            {
                anim[i].Play("7", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("8"))
            {
                anim[i].Play("8", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("9"))
            {
                anim[i].Play("9", -1, 0);
            }
            else if (anim[i].GetCurrentAnimatorStateInfo(0).IsName("Fill"))
            {
                anim[i].Play("Fill", -1, 0);
            }
        }
    }
}
