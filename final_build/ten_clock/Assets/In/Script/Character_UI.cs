using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_UI : MonoBehaviour
{
    public UnityEngine.UI.Text basic_1;
    public UnityEngine.UI.Text basic_2;
    public UnityEngine.UI.Text basic_3;
    public UnityEngine.UI.Text basic_4;
    public UnityEngine.UI.Text basic_5;
    public UnityEngine.UI.Image basic_6;
    public UnityEngine.UI.Image basic_7;
    public UnityEngine.UI.Image basic_8;

    public UnityEngine.UI.Image In_1;
    public UnityEngine.UI.Image In_2;
    public UnityEngine.UI.Image In_3;
    public UnityEngine.UI.Text In_4;
    public UnityEngine.UI.Text In_5;
    public UnityEngine.UI.Text In_6;
    public UnityEngine.UI.Text In_7;
    public UnityEngine.UI.Text In_8;

    public SpriteRenderer Image_1;
    public SpriteRenderer Image_2;
    public SpriteRenderer Image_3;
    public SpriteRenderer Image_4;
    public SpriteRenderer Image_5;
    public SpriteRenderer Image_6;
    public SpriteRenderer Image_7;


    public SpriteRenderer Character_1;
    public SpriteRenderer Character_2;
    public SpriteRenderer Character_3;

    public UnityEngine.UI.Image Fill_1;
    public UnityEngine.UI.Image Fill_2;

    public UnityEngine.UI.Image COUPON;
    public UnityEngine.UI.Image COUPON2;
    public UnityEngine.UI.Text coupn3;

    public UnityEngine.UI.Text champion_unlock;
    public SpriteRenderer champion_unlock2;

    public SpriteRenderer champion_unlock3;

    int tom = 0;
    int Fill = 0;

    public void Touch_panel()
    {
        tom = 1;
        Fill = 1;
    }

    public void Close()
    {
        tom = 0;
        Fill = 0;
    }

    public void Select_1()
    {
        Character_1.enabled = true;
        Character_2.enabled = false;
        Character_3.enabled = false;
        tom = 0;
    }

    public void Select_2()
    {
        Character_1.enabled = false;
        Character_2.enabled = true;
        Character_3.enabled = false;
        tom = 0;
    }

    // Use this for initialization
    void Start()
    {
        Character_1.enabled = true;
        Character_2.enabled = false;
        Character_3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Fill == 0)
        {
            Fill_1.fillAmount = 0f;
            Fill_2.fillAmount = 0f;
        }
        if (Fill == 1)
        {
            Fill_1.fillAmount += 0.005f;
            Fill_2.fillAmount += 0.005f;

            if (Fill_1.fillAmount > 0.0f)     // 검사 경험치
            {
                Fill_1.fillAmount = GetKnow1();
            }
            if (Fill_2.fillAmount > 0.0f)    // 격투가 경험치
            {
                Fill_2.fillAmount = GetKnow2();
            }
        }
        if (tom == 0)
        {
            COUPON.enabled = true;
            COUPON2.enabled = true;
            coupn3.enabled = true;

            In_1.enabled = false;
            In_2.enabled = false;
            In_3.enabled = false;
            In_4.enabled = false;
            In_5.enabled = false;
            In_6.enabled = false;
            In_7.enabled = false;
            In_8.enabled = false;

            basic_1.enabled = true;
            basic_2.enabled = true;
            basic_3.enabled = true;
            basic_4.enabled = true;
            basic_5.enabled = true;
            basic_6.enabled = true;
            basic_7.enabled = true;
            basic_8.enabled = true;

            Image_1.enabled = false;
            Image_2.enabled = false;
            Image_3.enabled = false;
            Image_4.enabled = false;
            Image_5.enabled = false;
            Image_6.enabled = false;
            Image_7.enabled = false;


            Fill_1.enabled = false;
            Fill_2.enabled = false;

            champion_unlock.enabled = false;
            champion_unlock2.enabled = false;
        }
        if (tom == 1)
        {
            COUPON.enabled = false;
            COUPON2.enabled = false;
            coupn3.enabled = false;

            In_1.enabled = true;
            In_2.enabled = true;
            In_4.enabled = true;
            In_5.enabled = true;
            In_7.enabled = true;
            In_8.enabled = true;

            basic_1.enabled = false;
            basic_2.enabled = false;
            basic_3.enabled = false;
            basic_4.enabled = false;
            basic_5.enabled = false;
            basic_6.enabled = false;
            basic_7.enabled = false;
            basic_8.enabled = false;

            Image_1.enabled = true;
            Image_2.enabled = true;
            Image_3.enabled = true;
            Image_4.enabled = true;
            Image_5.enabled = true;
            Image_6.enabled = true;
            Image_7.enabled = true;


            Fill_1.enabled = true;
            Fill_2.enabled = true;

            if (Coupon.bbbb == 0)
            {
                In_3.enabled = false;
                In_6.enabled = false;
                In_7.enabled = false;
                champion_unlock.enabled = true;
                champion_unlock2.enabled = true;
            }

            if (Coupon.bbbb == 1)
            {
                In_3.enabled = true;
                In_6.enabled = true;
                In_7.enabled = true;
                champion_unlock.enabled = false;
                champion_unlock2.enabled = false;
                champion_unlock3.enabled = false;
            }
        }
    }

    float GetKnow1()
    {
        if(PlayerPrefs.GetInt("Character") == 2)
        {
            if (PlayerPrefs.GetInt("LevelValue2") >= 19575)
            {
                return 1f;
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 11925) // 9레벨 일 때 7650의 경험치가 필요
            {
                return (float)(1/7650) * (float)(7650 - PlayerPrefs.GetInt("LevelValue2"));
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 7200) // 4725
            {
                return (float)(1/4725) * (float)(4725 - PlayerPrefs.GetInt("LevelValue2"));
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 4275) // 2925
            {
                return (float)(1/2925) * (float)(2925 - PlayerPrefs.GetInt("LevelValue2"));
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 2475) //1800
            {
                return (float)(1/1800) * (float)(1800 - PlayerPrefs.GetInt("LevelValue2"));
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 1350) //1125
            {
                return (float)(1/1125) * (float)(1125 - PlayerPrefs.GetInt("LevelValue2"));
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 675) //675
            {
                return (float)(1/675) * (float)(675 - PlayerPrefs.GetInt("LevelValue2"));
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 225) //450
            {
                return (float)(1/450) * (float)(450 - PlayerPrefs.GetInt("LevelValue2"));
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 75) //150
            {
                return (float)(1/150) * (float)(150 - PlayerPrefs.GetInt("LevelValue2"));
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 0)// 75
            {
                return (float)(1/75) * (float)(75 - PlayerPrefs.GetInt("LevelValue2"));
            }
        }
        return 0f;
    }

    float GetKnow2()
    {
        if(PlayerPrefs.GetInt("Character") == 1)
        {
            if (PlayerPrefs.GetInt("LevelValue1") >= 19575)
            {
                return 1f;
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 11925) // 9레벨 일 때 7650의 경험치가 필요
            {
                return (float)(1/7650) * (float)(7650 - PlayerPrefs.GetInt("LevelValue1"));
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 7200) // 4725
            {
                return (float)(1/4725) * (float)(4725 - PlayerPrefs.GetInt("LevelValue1"));
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 4275) // 2925
            {
                return (float)(1/2925) * (float)(2925 - PlayerPrefs.GetInt("LevelValue1"));
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 2475) //1800
            {
                return (float)(1/1800) * (float)(1800 - PlayerPrefs.GetInt("LevelValue1"));
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 1350) //1125
            {
                return (float)(1/1125) * (float)(1125 - PlayerPrefs.GetInt("LevelValue1"));
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 675) //675
            {
                return (float)(1/675) * (float)(675 - PlayerPrefs.GetInt("LevelValue1"));
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 225) //450
            {
                return (float)(1/450) * (float)(450 - PlayerPrefs.GetInt("LevelValue1"));
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 75) //150
            {
                return (float)(1/150) * (float)(150 - PlayerPrefs.GetInt("LevelValue1"));
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 0) //75
            {
                return (float)(1/75) * (float)(75 - PlayerPrefs.GetInt("LevelValue1"));
            }
        }
        return 0f;
    }
}
