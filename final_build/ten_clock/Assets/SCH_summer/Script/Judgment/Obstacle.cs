using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject bPrefab;

    public bool check;

    void Start()
    {
        check = true;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "TopN")
        {
            if(check)
            {
                GameObject _prefab = Instantiate(bPrefab);

		        _prefab.transform.SetParent(GameObject.Find("Canvas").transform);
                _prefab.transform.localPosition = new Vector3(12f, -490f);

                GameObject.Find("GameManager").GetComponent<HP_Control>().Hit_Top();
                GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().ComboReset();

                check = false;
            }
        }
    }
}
