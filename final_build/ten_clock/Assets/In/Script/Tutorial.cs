using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    public SpriteRenderer I1;
    public SpriteRenderer I2;
    public SpriteRenderer I3;
    public SpriteRenderer I4;
    public SpriteRenderer I5;
    public SpriteRenderer I6;
    public SpriteRenderer I7;
    public SpriteRenderer I8;
    public SpriteRenderer I9;
    public SpriteRenderer I10;
    public SpriteRenderer I11;
    public SpriteRenderer I12;
    public SpriteRenderer I13;
    public SpriteRenderer I14;
    public SpriteRenderer I15;
    public SpriteRenderer I16;
    public SpriteRenderer I17;
    public SpriteRenderer I18;

    public SpriteRenderer note1;
    public SpriteRenderer note2;

    float Tu_Timer = 0f;
    float fade_Timer = 0f;
    float fade = 0f;

    // Use this for initialization
    void Start()
    {
        Tu_Timer = 0;
        fade_Timer = 0;
        I1.enabled = false;
        I2.enabled = false;
        I3.enabled = false;
        I4.enabled = false;
        I5.enabled = false;
        I6.enabled = false;
        I7.enabled = false;
        I8.enabled = false;
        I9.enabled = false;
        I10.enabled = false;
        I11.enabled = false;
        I12.enabled = false;
        I13.enabled = false;
        I14.enabled = false;
        I15.enabled = false;
        I16.enabled = false;
        I17.enabled = false;
        I18.enabled = false;
        note1.enabled = false;
        note2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Tu_Timer += Time.deltaTime;
        fade_Timer += Time.deltaTime;
        if (Tu_Timer >= 0.2f)
        {
            I1.enabled = true;
            if (fade_Timer > 0.1f && Tu_Timer < 3.87f)
            {
                fade += 0.1f;
                I1.color = new Color(I1.color.r, I1.color.g, I1.color.b, fade);
                fade_Timer = 0;
            }
        }
        if (Tu_Timer >= 3.87f)
        {
            I1.enabled = false;
            I2.enabled = true;
        }

        if (Tu_Timer >= 7.62f)
        {
            I2.enabled = false;
            I3.enabled = true;
        }
        if (Tu_Timer >= 11.37f && Tu_Timer < 13.37f)
        {
            I3.enabled = false;
            fade_Timer += Time.deltaTime;
            I4.enabled = true;
            if (fade_Timer > 0.1f)
            {
                fade -= 0.1f;
                I4.color = new Color(I4.color.r, I4.color.g, I4.color.b, fade);
                fade_Timer = 0;
            }

        }
        if (Tu_Timer == 30.11f)
        {
            fade = 1.0f;
        }
        if (Tu_Timer >= 13.37f)
        {
            I3.enabled = false;
            I4.enabled = false;
        }
        if (Tu_Timer >= 30.11f)
        {
            I5.enabled = true;
        }
        if (Tu_Timer >= 33.86f)
        {
            I5.enabled = false;
            I6.enabled = true;
        }
        if (Tu_Timer >= 37.61f)
        {
            I6.enabled = false;
            I7.enabled = true;
        }
        if (Tu_Timer >= 41.36f)
        {
            I8.enabled = true;
            I7.enabled = false;
        }
        if (Tu_Timer >= 42.25f && Tu_Timer < 43.25f)
        {
            fade_Timer += Time.deltaTime;
            if (fade_Timer > 0.1f)
            {
                fade -= 0.1f;
                I8.color = new Color(I8.color.r, I8.color.g, I8.color.b, fade);
                fade_Timer = 0;
            }
        }
        if (Tu_Timer == 60.11f)
        {
            fade = 1.0f;
        }
        if (Tu_Timer >= 43.25f)
        {
            I8.enabled = false;

        }
        if (Tu_Timer >= 45.11f)
        {
            note1.enabled = true;
        }
        if (Tu_Timer >= 60.11f)
        {
            note1.enabled = false;
            I9.enabled = true;
        }
        if (Tu_Timer >= 63.86f)
        {
            I9.enabled = false;
            I10.enabled = true;
        }
        if (Tu_Timer >= 67.61f)
        {
            I10.enabled = false;
            I11.enabled = true;
        }
        if (Tu_Timer >= 71.36f)
        {
            I11.enabled = false;
            I12.enabled = true;
        }
        if (Tu_Timer >= 72.36f && Tu_Timer < 73.23f)
        {
            fade_Timer += Time.deltaTime;
            if (fade_Timer > 0.1f)
            {
                fade -= 0.1f;
                I12.color = new Color(I12.color.r, I12.color.g, I12.color.b, fade);
                fade_Timer = 0;
            }
        }
        if (Tu_Timer == 87.35f)
        {
            fade = 1.0f;
        }
        if (Tu_Timer >= 73.23f)
        {
            I12.enabled = false;
        }
        if (Tu_Timer >= 75.11f)
        {
            note2.enabled = true;
        }
        if (Tu_Timer >= 87.35f)
        {
            note2.enabled = false;
        }
        if (Tu_Timer >= 87.85f)
        {
            I13.enabled = true;
        }
        if (Tu_Timer >= 91.25f)
        {
            I13.enabled = false;
            I14.enabled = true;
        }
        if (Tu_Timer >= 93.85f)
        {
            I14.enabled = false;
            I15.enabled = true;
        }
        if (Tu_Timer >= 94.85f && Tu_Timer < 95.35f)
        {
            fade_Timer += Time.deltaTime;
            if (fade_Timer > 0.1f)
            {
                fade -= 0.1f;
                I15.color = new Color(I15.color.r, I15.color.g, I15.color.b, fade);
                fade_Timer = 0;
            }
        }
        if (Tu_Timer >= 95.35f)
        {
            I15.enabled = false;
        }
        if (Tu_Timer >= 106.73f)
        {
            I16.enabled = true;
        }
        if (Tu_Timer >= 108.73f)
        {
            I16.enabled = false;
            I17.enabled = true;
        }
        if (Tu_Timer >= 110.73f)
        {
            I17.enabled = false;
            I18.enabled = true;
        }
    }
}
