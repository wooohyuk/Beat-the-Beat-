using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option_Read : MonoBehaviour
{

    public UnityEngine.UI.Image re_panel;
    public UnityEngine.UI.Image read;

    int UI = 0;
    float read_a;
    float num;

    public void Read()
    {
        UI = 1;
    }

    public void Read_Panel()
    {
        UI = 0;
    }

    // Use this for initialization
    void Start()
    {
        re_panel.enabled = false;
        aa = read.transform.position.y;
        read_a = num;
    }

    // Update is called once per frame
    void Update()
    {
        if (UI == 1)
        {
            re_panel.enabled = true;
            read.enabled = true;
            read.transform.position = new Vector3(re_panel.transform.position.x, read_a, 0);
            read_a += 5f;
        }
        if (UI == 0)
        {
            read_a = num;
            re_panel.enabled = false;
            read.enabled = false;
        }
    }
}
