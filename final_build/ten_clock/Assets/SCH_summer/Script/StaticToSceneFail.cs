using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticToSceneFail : MonoBehaviour {

    public Text perfect;
    public Text good;
    public Text bad;
    public Text miss;
    public Text combo;
    public Text score;

    public Text rank;

    public Text[] musicName;
    public GameObject[] title;

    float morniung_timer = 0f;
    bool wal = false;
    int wall = 0;

    void Start()
    {
        perfect.text = StaticHome.perfectCount.ToString();
        good.text = StaticHome.goodCount.ToString();
        bad.text = StaticHome.badCount.ToString();
        miss.text = StaticHome.missCount.ToString();
        combo.text = StaticHome.comboCount.ToString();
        score.text = StaticHome.scoreCount.ToString();

        if (StaticHome.musicName == "Seven")
        {
            ChangeTitle(0);
        }
        else if(StaticHome.musicName == "Cake")
        {
            ChangeTitle(1);
        }
        else if (StaticHome.musicName == "FeelSoGood")
        {
            ChangeTitle(2);
        }
        else if (StaticHome.musicName == "CoverItUp")
        {
            ChangeTitle(3);
        }

        rank.text = "F";
    }

    void ChangeTitle(int num)
    {
        musicName[0].enabled = false;
        musicName[1].enabled = false;
        musicName[2].enabled = false;
        musicName[3].enabled = false;

        title[0].SetActive(false);
        title[1].SetActive(false);
        title[2].SetActive(false);
        title[3].SetActive(false);

        Debug.Log(num);

        wal = true;
        title[num].SetActive(true);
        wall = num;
    }

     void Update()
    {
        if (wal == true)
        {
            morniung_timer += Time.deltaTime;
            if (morniung_timer > 1.8f)
            {
                musicName[wall].enabled = true;
            }
        }
    }
}
