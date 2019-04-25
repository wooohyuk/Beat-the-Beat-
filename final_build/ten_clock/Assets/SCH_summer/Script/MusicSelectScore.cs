using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSelectScore : MonoBehaviour {

	public Text score;
	public Text combo;
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
		
	}

	public void SettingCombo1()
	{
        if (!PlayerPrefs.HasKey("ComboValue"))
        {
            PlayerPrefs.SetInt("ComboValue", 000);
            PlayerPrefs.Save();
        }

		combo.text = PlayerPrefs.GetInt("ComboValue").ToString();
	}

	public void SettingCombo2()
	{
		if (!PlayerPrefs.HasKey("ComboValue2"))
        {
            PlayerPrefs.SetInt("ComboValue2", 000);
            PlayerPrefs.Save();
        }

		combo.text = PlayerPrefs.GetInt("ComboValue2").ToString();
	}

	public void SettingCombo3()
	{
		if (!PlayerPrefs.HasKey("ComboValue3"))
        {
            PlayerPrefs.SetInt("ComboValue3", 000);
            PlayerPrefs.Save();
        }

		combo.text = PlayerPrefs.GetInt("ComboValue3").ToString();
	}

	public void SettingCombo4()
	{
		if (!PlayerPrefs.HasKey("ComboValue4"))
        {
            PlayerPrefs.SetInt("ComboValue4", 000);
            PlayerPrefs.Save();
        }

		combo.text = PlayerPrefs.GetInt("ComboValue4").ToString();
	}

	public void SettingScore1()
	{
		if (!PlayerPrefs.HasKey("ScoreValue"))
        {
            PlayerPrefs.SetInt("ScoreValue", 00000);
            PlayerPrefs.Save();
        }

        score.text = PlayerPrefs.GetInt("ScoreValue").ToString();
	}

	public void SettingScore2()
	{
		if (!PlayerPrefs.HasKey("ScoreValue2"))
        {
            PlayerPrefs.SetInt("ScoreValue2", 00000);
            PlayerPrefs.Save();
        }

        score.text = PlayerPrefs.GetInt("ScoreValue2").ToString();
	}

	public void SettingScore3()
	{
		if (!PlayerPrefs.HasKey("ScoreValue3"))
        {
            PlayerPrefs.SetInt("ScoreValue3", 00000);
            PlayerPrefs.Save();
        }

        score.text = PlayerPrefs.GetInt("ScoreValue3").ToString();
	}

	public void SettingScore4()
	{
		if (!PlayerPrefs.HasKey("ScoreValue4"))
        {
            PlayerPrefs.SetInt("ScoreValue4", 00000);
            PlayerPrefs.Save();
        }

        score.text = PlayerPrefs.GetInt("ScoreValue4").ToString();
	}
}
