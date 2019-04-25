using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_Alpha : MonoBehaviour {


    private SpriteRenderer Circle1;
    private SpriteRenderer Circle2;
    private SpriteRenderer Circle3;
    private SpriteRenderer Circle4;
    private SpriteRenderer Circle5;

    Arrow_Button arrow_button;

    // Use this for initialization
    void Start () {
        Circle1 = GameObject.Find("100_Circle (1)").GetComponent<SpriteRenderer>();
        Circle2 = GameObject.Find("100_Circle (2)").GetComponent<SpriteRenderer>();
        Circle3 = GameObject.Find("100_Circle (3)").GetComponent<SpriteRenderer>();
        Circle4 = GameObject.Find("100_Circle (4)").GetComponent<SpriteRenderer>();
        Circle5 = GameObject.Find("100_Circle (5)").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (Arrow_Button.Pos)
        {
            case 1:
              //  transform.position = new Vector3(0f, transform.position.y, transform.position.z);
                Circle1.color = new Color(Circle1.color.r, Circle1.color.g, Circle1.color.b, 1);
                Circle2.color = new Color(Circle2.color.r, Circle2.color.g, Circle2.color.b, 0.36f);
                Circle3.color = new Color(Circle3.color.r, Circle3.color.g, Circle3.color.b, 0.36f);
                Circle4.color = new Color(Circle4.color.r, Circle4.color.g, Circle4.color.b, 0.36f);
                Circle5.color = new Color(Circle5.color.r, Circle5.color.g, Circle5.color.b, 0.36f);
                break;
            case 2:
               // transform.position = new Vector3(17.76174f, transform.position.y, transform.position.z);
                Circle1.color = new Color(Circle1.color.r, Circle1.color.g, Circle1.color.b, 0.36f);
                Circle2.color = new Color(Circle2.color.r, Circle2.color.g, Circle2.color.b, 1);
                Circle3.color = new Color(Circle3.color.r, Circle3.color.g, Circle3.color.b, 0.36f);
                Circle4.color = new Color(Circle4.color.r, Circle4.color.g, Circle4.color.b, 0.36f);
                Circle5.color = new Color(Circle5.color.r, Circle5.color.g, Circle5.color.b, 0.36f);
                break;
            case 3:
               // transform.position = new Vector3(17.76174f * 2, transform.position.y, transform.position.z);
                Circle1.color = new Color(Circle1.color.r, Circle1.color.g, Circle1.color.b, 0.36f);
                Circle2.color = new Color(Circle2.color.r, Circle2.color.g, Circle2.color.b, 0.36f);
                Circle3.color = new Color(Circle3.color.r, Circle3.color.g, Circle3.color.b, 1);
                Circle4.color = new Color(Circle4.color.r, Circle4.color.g, Circle4.color.b, 0.36f);
                Circle5.color = new Color(Circle5.color.r, Circle5.color.g, Circle5.color.b, 0.36f);
                break;
            case 4:
               // transform.position = new Vector3(17.76174f * 3, transform.position.y, transform.position.z);
                Circle1.color = new Color(Circle1.color.r, Circle1.color.g, Circle1.color.b, 0.36f);
                Circle2.color = new Color(Circle2.color.r, Circle2.color.g, Circle2.color.b, 0.36f);
                Circle3.color = new Color(Circle3.color.r, Circle3.color.g, Circle3.color.b, 0.36f);
                Circle4.color = new Color(Circle4.color.r, Circle4.color.g, Circle4.color.b, 1);
                Circle5.color = new Color(Circle5.color.r, Circle5.color.g, Circle5.color.b, 0.36f);
                break;
            case 5:
               // transform.position = new Vector3(17.76174f * 4, transform.position.y, transform.position.z);
                Circle1.color = new Color(Circle1.color.r, Circle1.color.g, Circle1.color.b, 0.36f);
                Circle2.color = new Color(Circle2.color.r, Circle2.color.g, Circle2.color.b, 0.36f);
                Circle3.color = new Color(Circle3.color.r, Circle3.color.g, Circle3.color.b, 0.36f);
                Circle4.color = new Color(Circle4.color.r, Circle4.color.g, Circle4.color.b, 0.36f);
                Circle5.color = new Color(Circle5.color.r, Circle5.color.g, Circle5.color.b, 1);
                break;
        }
    }
        }

