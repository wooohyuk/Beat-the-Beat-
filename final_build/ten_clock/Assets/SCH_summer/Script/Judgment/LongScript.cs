using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongScript : MonoBehaviour
{
    public bool longIn; //롱노트가 구역으로 들어왔음을 판별
    GameObject longN;

    Vector3 moveVelocity;

    public GameObject pPrefab;

    public float minusSpeed;

    private void Start()
    {
        longIn = false;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "LongN")
        {
            longIn = true;
        }
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.tag == "LongN")
        {
            longN = col.gameObject;

            if (GameObject.Find("stick man(Clone)").GetComponent<StickMan_Control>().longAttacking)
            {
                col.gameObject.transform.localScale -= new Vector3(minusSpeed * Time.deltaTime, 0, 0);

                moveVelocity = Vector3.right;
                col.gameObject.transform.position += moveVelocity * (GameObject.Find("GameManager").GetComponent<TxtTest>().noteSpeed + 0.9f) * Time.deltaTime;
            }
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.tag == "LongN")
        {
            longIn = false;
            GameObject.Find("stick man(Clone)").GetComponent<StickMan_Control>().StartOnlyOnecCoroutine(0.133f, "Long_CheckS");
        }
    }

    public void LongOut()
    {
        longIn = false;
    }

    public void LongDestroy()
    {
        Destroy(longN);
    }
}
