using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.SceneManagement;

public class TxtTest : MonoBehaviour
{
    bool startNote;

    public string[] textValue;
    string searchText;

    double systemTime;
    double textTime;
    double minusTime;
    public float noteSpeed;

    public GameObject gumSa;
    public GameObject gukTo;

    int nextNote;
    int finalNextNote;

    bool finishDouble;

    public SpriteRenderer[] noteNum;

    private void Start()
    {
        if(PlayerPrefs.GetInt("Character") == 1)
        {
            Debug.Log("검사 생성");
            Instantiate(gumSa);
        }
        else if(PlayerPrefs.GetInt("Character") == 2)
        {
            Instantiate(gukTo);
        }

        finishDouble = true;
        startNote = false;
        minusTime = 0f;
        systemTime = 0;
        nextNote = 0;
        finalNextNote = 0;

        if(SceneManager.GetActiveScene().name == "4_Ingame1")
        {
            finalNextNote = 38;
            minusTime = 1.5f;
            noteSpeed = 8f;
            StaticHome.musicName = "Seven";
            GameObject.Find("LongZone").GetComponent<LongScript>().minusSpeed = 1.5f;
        }
        else if(SceneManager.GetActiveScene().name == "4_Ingame2")
        {
            finalNextNote = 110;
            minusTime = 1.7f;
            noteSpeed = 8f;
            StaticHome.musicName = "Cake";
            GameObject.Find("LongZone").GetComponent<LongScript>().minusSpeed = 1.5f;
        }
        else if(SceneManager.GetActiveScene().name == "4_Ingame3")
        {
            finalNextNote = 125;
            minusTime = 1.5f;
            noteSpeed = 10f;
            StaticHome.musicName = "FeelSoGood";
            GameObject.Find("LongZone").GetComponent<LongScript>().minusSpeed = 1.7f;
        }
        else if (SceneManager.GetActiveScene().name == "4_Ingame4")
        {
            finalNextNote = 147;
            minusTime = 1.3f;
            noteSpeed = 12f;
            StaticHome.musicName = "CoverItUp";
            GameObject.Find("LongZone").GetComponent<LongScript>().minusSpeed = 2.4f;
        }

        searchText = ",";
        //Parse();
        //StartCoroutine(CreateNode_Tutorial());
        //Debug.Log(textValue[nextNote].Substring(0, 1));
    }

    private void Update()
    {
        if(startNote)
        {
            systemTime += Time.deltaTime;
            double systemSub = Math.Round(systemTime, 2);

            if(nextNote >= finalNextNote)
            {
                if(finishDouble)
                {
                    finishDouble = false;
                    StartCoroutine(FinishGame());
                }
                return;
            }

            textTime = double.Parse(textValue[nextNote].Substring(textValue[nextNote].IndexOf(searchText) + 1, 6));

            if (systemSub >= textTime - minusTime)
            {
                //Debug.Log("시간 : " + systemSub + ", 노트번호 : " + int.Parse(textValue[nextNote].Substring(0, 1)) + ", 앙 : " + nextNote + ", d : " + textTime);
                Instati_Note(int.Parse(textValue[nextNote].Substring(0, 1)));
                nextNote++;
            }
        }
    }

    void Instati_Note(int num)
    {
        if (num == 5)
        {
            SpriteRenderer asdf = noteNum[num - 1];

            float scaleX = float.Parse(textValue[nextNote].Substring(textValue[nextNote].IndexOf(searchText) + 8, 4));

            asdf.transform.localScale = new Vector3(scaleX, 1, 1);

            Debug.Log(asdf.transform.localScale.x);

            Instantiate(asdf);

            return;
        }

        Instantiate(noteNum[num - 1]);
    }

    public void Change_boolNote()
    {
        startNote = true;
    }

    public string pathForDocumentsFile(string filename)
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            string path = Application.dataPath.Substring(0, Application.dataPath.Length - 5);
            path = path.Substring(0, path.LastIndexOf('/'));
            return Path.Combine(Path.Combine(path, "Documents"), filename);
        }
        else if (Application.platform == RuntimePlatform.Android)
        {
            string path = "jar:file://" + Application.dataPath + "!/assets/" + filename;
            return path;
        }
        else
        {
            string path = Application.dataPath;
            path = path.Substring(0, path.LastIndexOf('/'));
            return Path.Combine(path, filename);
        }
    }

    IEnumerator FinishGame() // 소리 점점 줄이기
    {
        GameObject.Find("MusicPlayer").GetComponent<WOO_player>().Finishmusic();
        Debug.Log("4.5초 뒤에 게임 종료");
        yield return new WaitForSeconds(4.5f);

        GameObject.Find("GameManager").GetComponent<FadeIn_Out>().exe_b = 2;
    }
    /*
    void Parse()
    {
        string[] textValue = File.ReadAllLines(@"Assets/Text/test.txt");
        string searchText = ",";
        Debug.Log("쉼표 위치 : " + textValue[0].IndexOf(searchText));
        Debug.Log("타입 : " + textValue[0].Substring(0, 1));
        Debug.Log("시간 : " + textValue[0].Substring(textValue[0].IndexOf(searchText) + 1, 4));
        Debug.Log("전체 문장 : " + textValue[0]);
    }
    */

    /*
IEnumerator CreateNode_Tutorial()
{
    while (true)
    {
        double systemTime = Math.Round(checkTime, 2);
        double textTime = double.Parse(textValue[0].Substring(textValue[0].IndexOf(searchText) + 1, 5));
        if (systemTime == textTime)
        {
            UnityEngine.Debug.Log(checkTime);
        }
        UnityEngine.Debug.Log(Math.Round(checkTime, 1));
        checkTime += 0.1f;
        yield return new WaitForSeconds(0.1f);
    }
}*/
}
