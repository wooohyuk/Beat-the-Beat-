using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaticToScene : MonoBehaviour {

    public Text perfect;
    public Text good;
    public Text bad;
    public Text miss;
    public Text combo;
    public Text score;

    public Text rank;

    public Text bestScore;
    public Text bestCombo;

    public Text[] musicName;
    public GameObject[] title;

    float morniung_timer = 0f;
    bool wal = false;
    int wall = 0;



    bool b = true;
    bool c = true;
    bool d = true;
    void Start ()
    {
        perfect.text = StaticHome.perfectCount.ToString();
        good.text = StaticHome.goodCount.ToString();
        bad.text = StaticHome.badCount.ToString();
        miss.text = StaticHome.missCount.ToString();
        combo.text = StaticHome.comboCount.ToString();
        score.text = StaticHome.scoreCount.ToString();

        bestScore.text = BestScoreCheck();
        bestCombo.text = BestComboCheck();

        rank.text = RankCalc();

        UpLevelValue();
    }
    

    string RankCalc()
    {
        if (StaticHome.musicName == "Seven")
        {
            Change_MusicText(0);
            float sum = 0;
            for(int i = 0; i < 28; i++)
            {
                sum += (300 + (i * 3)) + (1 + (int)(PlayerPrefs.GetInt("PlayerLevel") * 0.05f));
            }
            int num = (int)(sum * 0.95f); //95% 이상

            if(StaticHome.comboCount == 28) // 풀콤보일 때
            {
                Debug.Log(num);
             
                    return "S";
              
            }
            else if(StaticHome.scoreCount >= num)
            {
                return "A";
            }

            num = (int)(sum * 0.70f);

            if(StaticHome.scoreCount >= num) // 점수가 85% 이상일 때
            {
                return "A";
            }

            num = (int)(sum * 0.55f);

            if(StaticHome.scoreCount >= num)
            {
                return "B";
            }

            num = (int)(sum * 0.40f);
            
            if(StaticHome.scoreCount >= num)
            {
                return "C";
            }
        }
        else if(StaticHome.musicName == "Cake")
        {
            Change_MusicText(1);
            float sum = 0;
            for (int i = 0; i < 89; i++)
            {
                sum += (300 + (i * 3)) + (1 + (int)(PlayerPrefs.GetInt("PlayerLevel") * 0.05f));
            }
            int num = (int)(sum * 0.95f); //95% 이상

            if (StaticHome.comboCount == 89) // 풀콤보일 때
            {
                Debug.Log(num);
            
                    Achivement.Ach_1();
                    if (b == true)
                    {
                        Achivement.seebal += 1;
                        b = false;
                    }
                    return "S";
          
            }
            else if (StaticHome.scoreCount >= num)
            {
                return "A";
            }

            num = (int)(sum * 0.70f);

            if (StaticHome.scoreCount >= num) // 점수가 85% 이상일 때
            {
                return "A";
            }

            num = (int)(sum * 0.55f);

            if (StaticHome.scoreCount >= num)
            {
                return "B";
            }

            num = (int)(sum * 0.40f);

            if (StaticHome.scoreCount >= num)
            {
                return "C";
            }
           /* else
            {
                return "D";
            }*/
        }
        else if(StaticHome.musicName == "FeelSoGood")
        {
            Change_MusicText(2);
            float sum = 0;
            for (int i = 0; i < 117; i++)
            {
                sum += (300 + (i * 3)) + (1 + (int)(PlayerPrefs.GetInt("PlayerLevel") * 0.05f));
            }
            int num = (int)(sum * 0.95f); //95% 이상

            if (StaticHome.comboCount == 117) // 풀콤보일 때
            {
                Debug.Log(num);
          

                    Achivement.Ach_2();
                    if (c == true)
                    {
                        Achivement.seebal += 1;
                        c = false;
                    }
                    return "S";
       
            }
            else if (StaticHome.scoreCount >= num)
            {
                return "A";
            }

            num = (int)(sum * 0.70f);

            if (StaticHome.scoreCount >= num) // 점수가 85% 이상일 때
            {
                return "A";
            }

            num = (int)(sum * 0.55f);

            if (StaticHome.scoreCount >= num)
            {
                return "B";
            }

            num = (int)(sum * 0.40f);

            if (StaticHome.scoreCount >= num)
            {
                return "C";
            }
          /*  else
            {
                return "D";
            }*/
        }
        else if(StaticHome.musicName == "CoverItUp")
        {
            Change_MusicText(3);
            float sum = 0;
            for (int i = 0; i < 117; i++)
            {
                sum += (300 + (i * 3)) + (1 + (int)(PlayerPrefs.GetInt("PlayerLevel") * 0.05f));
            }
            int num = (int)(sum * 0.95f); //95% 이상

            if (StaticHome.comboCount == 117) // 풀콤보일 때
            {
                Debug.Log(num);
             
                    Achivement.Ach_1();
                    if (d == true)
                    {
                        Achivement.seebal += 1;
                        d = false;
                    }
                    return "S";
         
            }
            else if (StaticHome.scoreCount >= num)
            {
                return "A";
            }

            num = (int)(sum * 0.70f);

            if (StaticHome.scoreCount >= num) // 점수가 80% 이상일 때
            {
                return "A";
            }

            num = (int)(sum * 0.55f);

            if (StaticHome.scoreCount >= num)
            {
                return "B";
            }

            num = (int)(sum * 0.40f);

            if (StaticHome.scoreCount >= num)
            {
                return "C";
            }
        /*    else
            {
                return "D";
            }*/
        }

        return "D";
    }

    void Change_MusicText(int num)
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

    void UpLevelValue()
    {
        if (StaticHome.musicName == "Seven")
        {

        }
        else if (StaticHome.musicName == "Cake")
        {
            if(PlayerPrefs.GetInt("Character") == 1)
            {
                if(rank.text == "S")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 400);
                }
                else if(rank.text == "A")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 250);
                }
                else if (rank.text == "B")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 125);
                }
                else if (rank.text == "C")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 50);
                }
                else if (rank.text == "D")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 25);
                }
            }
            else
            {
                if(rank.text == "S")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 400);
                }
                else if(rank.text == "A")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 250);
                }
                else if (rank.text == "B")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 125);
                }
                else if (rank.text == "C")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 50);
                }
                else if (rank.text == "D")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 25);
                }
            }
            

            PlayerPrefs.Save();
        }
        else if (StaticHome.musicName == "FeelSoGood")
        {
            if(PlayerPrefs.GetInt("Character") == 1)
            {
                if (rank.text == "S")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 500);
                }
                else if (rank.text == "A")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 300);
                }
                else if (rank.text == "B")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 150);
                }
                else if (rank.text == "C")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 75);
                }
                else if (rank.text == "D")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 25);
                }
            }
            else
            {
                if (rank.text == "S")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 500);
                }
                else if (rank.text == "A")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 300);
                }
                else if (rank.text == "B")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 150);
                }
                else if (rank.text == "C")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 75);
                }
                else if (rank.text == "D")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 25);
                }
            }

            PlayerPrefs.Save();
        }
        else if (StaticHome.musicName == "CoverItUp")
        {
            if(PlayerPrefs.GetInt("Character") == 1)
            {
                if (rank.text == "S")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 600);
                }
                else if (rank.text == "A")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 350);
                }
                else if (rank.text == "B")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 175);
                }
                else if (rank.text == "C")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 100);
                }
                else if (rank.text == "D")
                {
                    PlayerPrefs.SetInt("LevelValue1", PlayerPrefs.GetInt("LevelValue1") + 50);
                }
            }
            else
            {
                if (rank.text == "S")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 600);
                }
                else if (rank.text == "A")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 350);
                }
                else if (rank.text == "B")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 175);
                }
                else if (rank.text == "C")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 100);
                }
                else if (rank.text == "D")
                {
                    PlayerPrefs.SetInt("LevelValue2", PlayerPrefs.GetInt("LevelValue2") + 50);
                }
            }

            PlayerPrefs.Save();
        }
    }

    string BestScoreCheck()
    {
        if (StaticHome.musicName == "Seven")
        {
            if (!PlayerPrefs.HasKey("ScoreValue"))
            {
                PlayerPrefs.SetInt("ScoreValue", 00000);
                PlayerPrefs.Save();
            }

            if(PlayerPrefs.GetInt("ScoreValue") <= StaticHome.scoreCount)
            {
                PlayerPrefs.SetInt("ScoreValue", StaticHome.scoreCount);
                PlayerPrefs.Save();
            }

            string asdf = PlayerPrefs.GetInt("ScoreValue").ToString();

            return asdf;
        }
        else if (StaticHome.musicName == "Cake")
        {
            if (!PlayerPrefs.HasKey("ScoreValue2"))
            {
                PlayerPrefs.SetInt("ScoreValue2", 00000);
                PlayerPrefs.Save();
            }

            if(PlayerPrefs.GetInt("ScoreValue2") <= StaticHome.scoreCount)
            {
                PlayerPrefs.SetInt("ScoreValue2", StaticHome.scoreCount);
                PlayerPrefs.Save();
            }

            string asdf = PlayerPrefs.GetInt("ScoreValue2").ToString();

            return asdf;
        }
        else if (StaticHome.musicName == "FeelSoGood")
        {
            if (!PlayerPrefs.HasKey("ScoreValue3"))
            {
                PlayerPrefs.SetInt("ScoreValue3", 00000);
                PlayerPrefs.Save();
            }

            if(PlayerPrefs.GetInt("ScoreValue3") <= StaticHome.scoreCount)
            {
                PlayerPrefs.SetInt("ScoreValue3", StaticHome.scoreCount);
                PlayerPrefs.Save();
            }

            string asdf = PlayerPrefs.GetInt("ScoreValue3").ToString();

            return asdf;
        }
        else if (StaticHome.musicName == "CoverItUp")
        {
            if (!PlayerPrefs.HasKey("ScoreValue4"))
            {
                PlayerPrefs.SetInt("ScoreValue4", 00000);
                PlayerPrefs.Save();
            }

            if(PlayerPrefs.GetInt("ScoreValue4") <= StaticHome.scoreCount)
            {
                PlayerPrefs.SetInt("ScoreValue4", StaticHome.scoreCount);
                PlayerPrefs.Save();
            }

            string asdf = PlayerPrefs.GetInt("ScoreValue4").ToString();

            return asdf;
        }

        return "";
    }

    string BestComboCheck()
    {
        if (StaticHome.musicName == "Seven")
        {
            if (!PlayerPrefs.HasKey("ComboValue"))
            {
                PlayerPrefs.SetInt("ComboValue", 000);
                PlayerPrefs.Save();
            }

            if(PlayerPrefs.GetInt("ComboValue") <= StaticHome.comboCount)
            {
                PlayerPrefs.SetInt("ComboValue", StaticHome.comboCount);
                PlayerPrefs.Save();
            }

            string asdf = PlayerPrefs.GetInt("ComboValue").ToString();

            return asdf;
        }
        else if (StaticHome.musicName == "Cake")
        {
            if (!PlayerPrefs.HasKey("ComboValue2"))
            {
                PlayerPrefs.SetInt("ComboValue2", 000);
                PlayerPrefs.Save();
            }

            if(PlayerPrefs.GetInt("ComboValue2") <= StaticHome.comboCount)
            {
                PlayerPrefs.SetInt("ComboValue2", StaticHome.comboCount);
                PlayerPrefs.Save();
            }

            string asdf = PlayerPrefs.GetInt("ComboValue2").ToString();

            return asdf;
        }
        else if (StaticHome.musicName == "FeelSoGood")
        {
            if (!PlayerPrefs.HasKey("ComboValue3"))
            {
                PlayerPrefs.SetInt("ComboValue3", 000);
                PlayerPrefs.Save();
            }

            if(PlayerPrefs.GetInt("ComboValue3") <= StaticHome.comboCount)
            {
                PlayerPrefs.SetInt("ComboValue3", StaticHome.comboCount);
                PlayerPrefs.Save();
            }

            string asdf = PlayerPrefs.GetInt("ComboValue3").ToString();

            return asdf;
        }
        else if (StaticHome.musicName == "CoverItUp")
        {
            if (!PlayerPrefs.HasKey("ComboValue4"))
            {
                PlayerPrefs.SetInt("ComboValue4", 000);
                PlayerPrefs.Save();
            }

            if(PlayerPrefs.GetInt("ComboValue4") <= StaticHome.comboCount)
            {
                PlayerPrefs.SetInt("ComboValue4", StaticHome.comboCount);
                PlayerPrefs.Save();
            }

            string asdf = PlayerPrefs.GetInt("ComboValue4").ToString();

            return asdf;
        }

        return "";
    }
}
