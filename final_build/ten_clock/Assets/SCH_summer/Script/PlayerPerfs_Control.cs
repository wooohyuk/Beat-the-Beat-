using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPerfs_Control : MonoBehaviour
{
	void Start ()
    {
		if(!PlayerPrefs.HasKey("LevelValue1")) //경험치 총 량
        {
            PlayerPrefs.SetInt("LevelValue1", 0);
            PlayerPrefs.Save();
        }

        if(!PlayerPrefs.HasKey("LevelValue2")) //경험치 총 량
        {
            PlayerPrefs.SetInt("LevelValue2", 0);
            PlayerPrefs.Save();
        }

        if(!PlayerPrefs.HasKey("Character")) //캐릭터를 선택된거 확인하는거 
        {
            PlayerPrefs.SetInt("Character", 1);
            PlayerPrefs.Save();
        }

        if(!PlayerPrefs.HasKey("OpenCharacter"))    //격투가 열렀는지
        {
            PlayerPrefs.SetInt("OpenCharacter", 0);
            PlayerPrefs.Save();
        }

        if(!PlayerPrefs.HasKey("Character1"))   //캐릭터 1 경험치
        {
            PlayerPrefs.SetInt("Character1", 1);
            PlayerPrefs.Save();
        }

        if(!PlayerPrefs.HasKey("Character2"))   //캐릭터 2 경험치
        {
            PlayerPrefs.SetInt("Character2", 1);
            PlayerPrefs.Save();
        }

        if(!PlayerPrefs.HasKey("PlayerLevel"))  //플레이어 총 경험치
        {
            PlayerPrefs.SetInt("PlayerLevel", 1);
            PlayerPrefs.Save();
        }

        CaclLevel();
	}

    public void Get_StickMan1()
    {
        PlayerPrefs.SetInt("Character", 1);
        PlayerPrefs.Save();
    }

    public void Get_StickMan2()
    {
        PlayerPrefs.SetInt("Character", 2);
        PlayerPrefs.Save();
    }

    void CaclLevel()
    {
        if(PlayerPrefs.GetInt("OpenCharacter") == 1) //격투가 열렸으면
        {
            PlayerPrefs.SetInt("PlayerLevel", PlayerPrefs.GetInt("Character1") + PlayerPrefs.GetInt("Character2"));
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetInt("PlayerLevel", PlayerPrefs.GetInt("Character1"));
            PlayerPrefs.Save();
        }

        if(PlayerPrefs.GetInt("Character") == 1)
        {
            if (PlayerPrefs.GetInt("LevelValue1") >= 19575)
            {
                Achivement.Ach_5();
                StaticHome.playerlevel = 10;
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 11925)
            {
                StaticHome.playerlevel = 9;
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 7200)
            {
                StaticHome.playerlevel = 8;
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 4275)
            {
                StaticHome.playerlevel = 7;
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 2475)
            {
                StaticHome.playerlevel = 6;
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 1350)
            {
                StaticHome.playerlevel = 5;
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 675)
            {
                StaticHome.playerlevel = 4;
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 225)
            {
                StaticHome.playerlevel = 3;
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 75)
            {
                StaticHome.playerlevel = 2;
            }
            else if (PlayerPrefs.GetInt("LevelValue1") >= 0)
            {
                StaticHome.playerlevel = 1;
            }
        }
        else if(PlayerPrefs.GetInt("Character") == 2)
        {
            if (PlayerPrefs.GetInt("LevelValue2") >= 19575)
            {
                Achivement.Ach_6();
                StaticHome.playerlevel = 10;
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 11925)
            {
                StaticHome.playerlevel = 9;
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 7200)
            {
                StaticHome.playerlevel = 8;
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 4275)
            {
                StaticHome.playerlevel = 7;
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 2475)
            {
                StaticHome.playerlevel = 6;
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 1350)
            {
                StaticHome.playerlevel = 5;
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 675)
            {
                StaticHome.playerlevel = 4;
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 225)
            {
                StaticHome.playerlevel = 3;
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 75)
            {
                StaticHome.playerlevel = 2;
            }
            else if (PlayerPrefs.GetInt("LevelValue2") >= 0)
            {
                StaticHome.playerlevel = 1;
            }
        }
    }
}
