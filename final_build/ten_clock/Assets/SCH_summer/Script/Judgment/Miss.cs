using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miss : MonoBehaviour 
{
    public GameObject bPrefab;

	void OnCollisionEnter2D(Collision2D col)
	{
        if(col.gameObject.tag == "TopN")
        {
            return;
        }

        GameObject _prefab = Instantiate(bPrefab);

		_prefab.transform.SetParent(GameObject.Find("Canvas").transform);
        _prefab.transform.localPosition = new Vector3(12f, -490f);

        if(col.gameObject.tag == "LongN")
        {
            GameObject.Find("LongZone").GetComponent<LongScript>().LongOut();
            Destroy(col.gameObject);
            GameObject.Find("GameManager").GetComponent<HP_Control>().Hit_Long();
            StaticHome.missCount++;
            GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().ComboReset();
        }

        if (col.gameObject.tag == "LeftN")
        {
            Destroy(col.gameObject);
            GameObject.Find("GameManager").GetComponent<HP_Control>().Hit_None();
            StaticHome.missCount++;
            GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().ComboReset();
        }

		if (col.gameObject.tag == "RightN")
        {
            Destroy(col.gameObject);
            GameObject.Find("GameManager").GetComponent<HP_Control>().Hit_None();
            StaticHome.missCount++;
            GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().ComboReset();
        }

        if (col.gameObject.tag == "TapN")
        {
            Destroy(col.gameObject);
            GameObject.Find("GameManager").GetComponent<HP_Control>().Hit_None();
            StaticHome.missCount++;
            GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().ComboReset();
		}
	}

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "TopN")
        {
            GameObject.Find("BodyZone").GetComponent<Obstacle>().check = true;
            return;
        }
    }
}
