using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    void Update()
    {
        gameObject.GetComponent<Image>().color -= new Color(0, 0, 0, Time.deltaTime * 1.7f);

        if (gameObject.GetComponent<Image>().color.a <= 0)
            Destroy(gameObject);
    }
}
