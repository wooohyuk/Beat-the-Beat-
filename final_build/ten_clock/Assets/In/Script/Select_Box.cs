using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_Box : MonoBehaviour
{
    float timer;
   // float a;
    bool check= true;
    public static int kimozzi = 1;
    private SpriteRenderer Box;

    public SpriteRenderer Seven;
    public SpriteRenderer Cover_It_Up;
    public SpriteRenderer Feel_So_Good;
    public SpriteRenderer Cake;

    public UnityEngine.UI.Text tu;
    public UnityEngine.UI.Text one;
    public UnityEngine.UI.Text two;
    public UnityEngine.UI.Text three;

    public UnityEngine.UI.Text under_1;
    public UnityEngine.UI.Text under_11;
    public UnityEngine.UI.Text under_2;
    public UnityEngine.UI.Text under_3;
    public UnityEngine.UI.Text under_4;

    public UnityEngine.UI.Text uunder_1;
    public UnityEngine.UI.Text uunder_2;
    public UnityEngine.UI.Text uunder_3;
    public UnityEngine.UI.Text uunder_4;

    public void Touch_1()
    {
        kimozzi = 1;
    }
    public void Touch_2()
    {
        kimozzi = 2;
    }
    public void Touch_3()
    {
        kimozzi = 3;
    }
    public void Touch_4()
    {
        kimozzi = 4;
    }


    // Use this for initialization
    void Start()
    {
        Box = GameObject.Find("MUSIC_SELECT_BOX").GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (kimozzi == 1)
        {

            GameObject.Find("Main Camera").GetComponent<MusicSelectScore>().SettingCombo1();
            GameObject.Find("Main Camera").GetComponent<MusicSelectScore>().SettingScore1();
            if (check == true)
            {
                tu.enabled = false;
                timer += Time.deltaTime;
                if (timer > 0.4f)
                {
                    tu.enabled = true;
                    check = false;
                    timer = 0;
                }
            }
            else
            {
                tu.enabled = true;
            }
            Box.transform.position = new Vector3(transform.position.x, 2.521935f, transform.position.z);
            Seven.enabled = true;
            Feel_So_Good.enabled = false;
            Cake.enabled = false;
            Cover_It_Up.enabled = false;

           
            one.enabled = false;
            two.enabled = false;
            three.enabled = false;

            under_1.enabled = true;
            under_11.enabled = true;
            under_2.enabled = false;
            under_3.enabled = false;
            under_4.enabled = false;

            uunder_1.enabled = true;
            uunder_2.enabled = false;
           uunder_3.enabled = false;
            uunder_4.enabled = false;
        }

        if (kimozzi == 2)
        {
            GameObject.Find("Main Camera").GetComponent<MusicSelectScore>().SettingCombo2();
            GameObject.Find("Main Camera").GetComponent<MusicSelectScore>().SettingScore2();
            Box.transform.position = new Vector3(transform.position.x, 1.47935f, transform.position.z);
            Seven.enabled = false;
            Feel_So_Good.enabled = false;
            Cake.enabled = true;
            Cover_It_Up.enabled = false;

            
            tu.enabled = false;
            one.enabled = true;
            two.enabled = false;
            three.enabled = false;

            under_1.enabled = false;
            under_11.enabled = false;
            under_2.enabled = true;
            under_3.enabled = false;
            under_4.enabled = false;

            uunder_1.enabled = false;
            uunder_2.enabled = true;
            uunder_3.enabled = false;
            uunder_4.enabled = false;
        }
        if (kimozzi == 3)
        {

            GameObject.Find("Main Camera").GetComponent<MusicSelectScore>().SettingCombo3();
            GameObject.Find("Main Camera").GetComponent<MusicSelectScore>().SettingScore3();
            Box.transform.position = new Vector3(transform.position.x, 0.385f, transform.position.z);
            Seven.enabled = false;
            Feel_So_Good.enabled = true;
            Cake.enabled = false;
            Cover_It_Up.enabled = false;

            tu.enabled = false;
            one.enabled = false;
            two.enabled = true;
            three.enabled = false;

            under_1.enabled = false;
            under_11.enabled = false;
            under_2.enabled = false;
            under_3.enabled = true;
            under_4.enabled = false;

            uunder_1.enabled = false;
            uunder_2.enabled = false;
            uunder_3.enabled = true;
            uunder_4.enabled = false;
        }
        if (kimozzi == 4)
        {

            GameObject.Find("Main Camera").GetComponent<MusicSelectScore>().SettingCombo4();
            GameObject.Find("Main Camera").GetComponent<MusicSelectScore>().SettingScore4();
            Box.transform.position = new Vector3(transform.position.x, -0.725f, transform.position.z);
            Seven.enabled = false;
            Feel_So_Good.enabled = false;
            Cake.enabled = false;
            Cover_It_Up.enabled = true;

            tu.enabled = false;
            one.enabled = false;
            two.enabled = false;
            three.enabled = true;

            under_1.enabled = false;
            under_11.enabled = false;
            under_2.enabled = false;
            under_3.enabled = false;
            under_4.enabled = true;

            uunder_1.enabled = false;
            uunder_2.enabled = false;
            uunder_3.enabled = false;
            uunder_4.enabled = true;
        }

    }
}
