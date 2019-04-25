using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Note_Control : MonoBehaviour
{
    public float speed; 
    Vector3 moveVelocity;

    public GameObject pPrefab;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "4_Ingame1")
        {
            speed = 8f;
        }
        else if(SceneManager.GetActiveScene().name == "4_Ingame2")
        {
            speed = 8f;
        }
        else if (SceneManager.GetActiveScene().name == "4_Ingame3")
        {
            speed = 10f;
        }
        else if (SceneManager.GetActiveScene().name == "4_Ingame4")
        {
            speed = 12f;
        }
        Destroy(gameObject, 7f);
    }

    void Update()
    {
        if (gameObject.tag == "LongN")
        {
            moveVelocity = Vector3.left;
            transform.position += moveVelocity * speed * Time.deltaTime;

            if (gameObject.transform.localScale.x <= 0f)
            {
                GameObject.Find("stick man(Clone)").GetComponent<StickMan_Control>().StartOnlyOnecCoroutine(0.133f, "Long_CheckS");
                GameObject.Find("LongZone").GetComponent<LongScript>().LongOut();
                StaticHome.perfectCount++;
                GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().JumPlus(300);
                GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().ComboPlus();

                GameObject _prefab = Instantiate(pPrefab);

                _prefab.transform.SetParent(GameObject.Find("Canvas").transform);
                _prefab.transform.localPosition = new Vector3(12f, -490f);

                Destroy(gameObject);
            }

            return;
        }

        moveVelocity = Vector3.left;
        transform.position += moveVelocity * speed * Time.deltaTime;
    }
}
