using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{


    private void Start()
    {
        StartCoroutine(LoadScene());
    }



    IEnumerator LoadScene()
    {
        yield return null;

        AsyncOperation oper = null;

        if (Select_Box.kimozzi == 1)
        {
            oper = SceneManager.LoadSceneAsync("4_Ingame1");
        }
        else if(Select_Box.kimozzi == 2)
        {
            oper = SceneManager.LoadSceneAsync("4_Ingame2");
        }
        else if (Select_Box.kimozzi == 3)
        {
            oper = SceneManager.LoadSceneAsync("4_Ingame3");
        }
        else if (Select_Box.kimozzi == 4)
        {
            oper = SceneManager.LoadSceneAsync("4_Ingame4");
        }
        //LoadSceneAsync ("게임씬이름"); 입니다.
        oper.allowSceneActivation = false;
        //allowSceneActivation 이 true가 되는 순간이 바로 다음 씬으로 넘어가는 시점입니다.

        float timer = 0.0f;
        while (!oper.isDone)
        {
            yield return null;

            timer += Time.deltaTime;
            if (timer > 5.0f)
                oper.allowSceneActivation = true;

        }
    }
}

