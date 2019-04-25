using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Good : MonoBehaviour 
{
    public GameObject noteCheck;
    public GameObject particleExplosion; //노트 터질 때 이펙트

    void Start()
    {
        noteCheck = null;
    }
	void OnCollisionStay2D(Collision2D col)
    {
		if (col.gameObject.tag == "LeftN")
        {
            GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().noteNumCheckG = 1;
            noteCheck = col.gameObject;
        }

		if (col.gameObject.tag == "RightN")
        {
            GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().noteNumCheckG = 2;
            noteCheck = col.gameObject;
        }

        if (col.gameObject.tag == "TapN")
        {
            GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().noteNumCheckG = 3;
            noteCheck = col.gameObject;
        }
    }

    public void Destroy_colObject()
    {
        if(noteCheck != null)
        {
            Instantiate(particleExplosion, noteCheck.transform.position, Quaternion.identity);
            Destroy(noteCheck);
            noteCheck = null;
        }
    }
}
