using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coupon : MonoBehaviour
{

    //임시용 갈고 뒤끝 사용
    public UnityEngine.UI.InputField coupon;

    public UnityEngine.UI.Image A;
    public UnityEngine.UI.Image B;
    public UnityEngine.UI.Image C;
    public UnityEngine.UI.Image D;
    public UnityEngine.UI.Image E;
    public UnityEngine.UI.Image F;

    public UnityEngine.UI.Image panela;

    public UnityEngine.UI.Text a;
    public UnityEngine.UI.Text b;
    public UnityEngine.UI.Text c;

    public UnityEngine.UI.Text e;
    public UnityEngine.UI.Text f;

    public SpriteRenderer messenger;
    public SpriteRenderer messenger2;
    public SpriteRenderer messenger3;
    public SpriteRenderer messenger4;


    int aaaa = 0;

    public static int bbbb = 0;

    int cccc = 1;

    float yy = 5.72f;

    float messenger_timer = 0;
    float messenger_timer2 = 0;
    float messenger_timer4 = 0;

    float m_alpha = 1f;

    int Kimotti = 0;
    public void Click()
    {
        string convertName = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(coupon.text));
        PlayerPrefs.SetString("Coupon", convertName);
        PlayerPrefs.Save();
    }

    public void Click_2()
    {
        aaaa = 1;
    }

    public void Click_3()
    {
        aaaa = 2;
    }



    // Use this for initialization
    void Start()
    {
       //PlayerPrefs.DeleteKey("Coupon");
        messenger4.enabled = false;
        
        A.enabled = true;
        B.enabled = true;

        a.enabled = true;

        C.enabled = false;
        D.enabled = false;
        E.enabled = false;
        F.enabled = false;

        panela.enabled = false;

        b.enabled = false;
        c.enabled = false;

        coupon.placeholder.enabled = false;
        coupon.image.enabled = false;
        e.enabled = false;
        f.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (aaaa == 1)
        {
            A.enabled = false;
            B.enabled = false;

            a.enabled = false;

            C.enabled = true;
            D.enabled = true;
            E.enabled = true;
            F.enabled = true;

            panela.enabled = true;

            b.enabled = true;
            c.enabled = true;

            coupon.placeholder.enabled = true;
            coupon.image.enabled = true;
            e.enabled = true;
            f.enabled = true;
        }

        if (aaaa == 2)
        {
            A.enabled = true;
            B.enabled = true;

            a.enabled = true;

            C.enabled = false;
            D.enabled = false;
            E.enabled = false;
            F.enabled = false;

            panela.enabled = false;

            b.enabled = false;
            c.enabled = false;

            coupon.placeholder.enabled = false;
            coupon.image.enabled = false;
            e.enabled = false;
            f.enabled = false;
        }


        if (System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(PlayerPrefs.GetString("Coupon"))) == "HANSEI"
            || System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(PlayerPrefs.GetString("Coupon"))) == "SCH"
            || System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(PlayerPrefs.GetString("Coupon"))) == "SUNRIN"
            || System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(PlayerPrefs.GetString("Coupon"))) == "SOGANG"
            || System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(PlayerPrefs.GetString("Coupon"))) == "Pyeongchon"
            || System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(PlayerPrefs.GetString("Coupon"))) == "KYUNGMIN"
            || System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(PlayerPrefs.GetString("Coupon"))) == "LifeCoding"
             || System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(PlayerPrefs.GetString("Coupon"))) == "Indiera"
             || System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(PlayerPrefs.GetString("Coupon"))) == "Daeil")
        {
            PlayerPrefs.SetInt("OpenCharacter", 1);
            PlayerPrefs.Save();
            bbbb = 1;
        }

        if (bbbb == 1)
        {
            if (cccc == 1)
            {
                messenger_timer += Time.deltaTime;
                messenger_timer2 += Time.deltaTime;
                if (messenger_timer >= 0.01f)
                {
                    yy -= 0.1f;
                    messenger.transform.position = new Vector3(messenger.transform.position.x, yy, messenger.transform.position.z);
                    if (yy <= 4.27f)
                    {
                        yy = 4.27f;
                        if (messenger_timer2 >= 1.7f)
                        {
                            cccc = 2;
                            messenger_timer2 = 0;
                        }
                    }
                    messenger_timer = 0;
                }
            }

            if (cccc == 2)
            {
                messenger_timer += Time.deltaTime;
                if (messenger_timer >= 0.01f)
                {
                    yy += 0.1f;
                    messenger.transform.position = new Vector3(messenger.transform.position.x, yy, messenger.transform.position.z);
                    if (yy >= 5.72f)
                    {
                        yy = 5.72f;
                        cccc = 2;
                    }
                    messenger_timer = 0;
                }
            }
        }
    }
}
