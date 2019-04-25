using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_Control : MonoBehaviour
{
    public Image maskImage;
    public Text hpText;

    int hpGag;

    int maxHp;

    int noneDmg;
    int longDmg;
    int topDmg;

    bool finishDouble;

	void Start ()
    {
        GetMaxHp();

        finishDouble = true;

        hpGag = maxHp;
        hpText.text = hpGag.ToString() + " / " + maxHp.ToString();

        noneDmg = 40;
        longDmg = 40;
        topDmg = 50;
	}
	
	void Update ()
    {
        if(hpGag <= 0)
        {
            if(finishDouble)
            {
                finishDouble = false;
                StaticHome.finalScore = "F";
                GameObject.Find("GameManager").GetComponent<FadeIn_Out>().exe_b = 2;
            }
        }
	}

    public void Hit_None()
    {
        hpGag -= noneDmg;
        hpText.text = hpGag.ToString() + " / " + maxHp.ToString();
        StartCoroutine(MinusHpBar(0.4f));
    }

    public void Hit_Long()
    {
        hpGag -= longDmg;
        hpText.text = hpGag.ToString() + " / " + maxHp.ToString();
        StartCoroutine(MinusHpBar(0.4f));
    }

    public void Hit_Top()
    {
        hpGag -= topDmg;
        hpText.text = hpGag.ToString() + " / " + maxHp.ToString();
        StartCoroutine(MinusHpBar(0.5f));
    }

    IEnumerator MinusHpBar(float ang)
    {
        float checkk = 0;
        bool check = true;

        while(check)
        {
            yield return new WaitForSeconds(.015f);

            maskImage.rectTransform.localScale -= new Vector3(0.02f, 0, 0);

            checkk += 0.02f;

            if(checkk >= ang)
            {
                check = false;
            }
        }
    }

    void GetMaxHp()
    {
        Debug.Log("asdf");
        if(StaticHome.playerlevel == 1)
        {
            maxHp = 200;
        }
        else if(StaticHome.playerlevel == 2)
        {
            maxHp = 225;
        }
        else if (StaticHome.playerlevel == 3)
        {
            maxHp = 250;
        }
        else if (StaticHome.playerlevel == 4)
        {
            maxHp = 275;
        }
        else if (StaticHome.playerlevel == 5)
        {
            maxHp = 300;
        }
        else if (StaticHome.playerlevel == 6)
        {
            maxHp = 325;
        }
        else if (StaticHome.playerlevel == 7)
        {
            maxHp = 350;
        }
        else if (StaticHome.playerlevel == 8)
        {
            maxHp = 375;
        }
        else if (StaticHome.playerlevel == 9)
        {
            maxHp = 400;
        }
        else if (StaticHome.playerlevel == 10)
        {
            maxHp = 425;
        }
    }
}
