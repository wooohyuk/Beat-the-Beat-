using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Judgment_Manage : MonoBehaviour 
{
	public BoxCollider2D perfectZone; //퍼펙트 충돌 구역 확
	public BoxCollider2D goodZone; //굿 충돌 구역 확인
    public BoxCollider2D badZone;
    public BoxCollider2D jumpZone; //점프 충돌 구역 확인

	public GameObject gPrefab; //판정 표시 패널
	public GameObject pPrefab;
    public GameObject bPrefab;

	public int noteNumCheckP; //노트와 제스처 일치 확인
	public int noteNumCheckG; //노트와 제스처 일치 확인 (굿 버전)
    public int noteNumCheckB;

	public Text comboText; //콤보 표시하는 텍스트
	int comboCount; //콤보 수 누적

	public Text jumText; //점수 표시하는 텍스트
	int jumCount; //점수 누적

	void Start () 
	{
		noteNumCheckP = 0;
		noteNumCheckG = 0;
        noteNumCheckB = 0;
		perfectZone.enabled = false;
		goodZone.enabled = false;
        badZone.enabled = false;
        jumpZone.enabled = true;
		comboCount = 0;
		jumCount = 0;
		comboText.text = comboCount.ToString();
		jumText.text = jumCount.ToString();
	}

	public void DestroyNote(int same) //애니메이션 실행으로 인한 함수
	{
		perfectZone.enabled = true;
		goodZone.enabled = true;
        badZone.enabled = true;
        
		StartCoroutine(OneWait(same));
	}

    public void JumpEvasionFalse() //점프 시작 -> 구역 비할성화
    {
        jumpZone.enabled = false;
        StartCoroutine(JumpWait());
    }

    IEnumerator OneWait(int same)
	{
		yield return new WaitForSeconds(.2f);

		perfectZone.enabled = false;
		goodZone.enabled = false;
        badZone.enabled = false;

		if(GameObject.Find("GoodZone").GetComponent<Good>().noteCheck == null && GameObject.Find("BadZone").GetComponent<Bad>().noteCheck == null)
		{
			if(GameObject.Find("PerFectZone").GetComponent<Perfect>().noteCheck == null)
			{

			}
			else if(GameObject.Find("PerFectZone").GetComponent<Perfect>().noteCheck != null) //Perfect
			{
				if(noteNumCheckP == same)
				{        
					GameObject _prefab = Instantiate(pPrefab);

					_prefab.transform.SetParent(GameObject.Find("Canvas").transform);
        			_prefab.transform.localPosition = new Vector3(12f, -490f);

					GameObject.Find("PerFectZone").GetComponent<Perfect>().Destroy_colObject();
                    StaticHome.perfectCount++;
                    ComboPlus();
					JumPlus(300);
				}
			}
		}
		else if(GameObject.Find("BadZone").GetComponent<Bad>().noteCheck == null)
		{
            if(GameObject.Find("GoodZone").GetComponent<Good>().noteCheck == null)
            {

            }
            else if(GameObject.Find("GoodZone").GetComponent<Good>().noteCheck != null)
            {
                if (noteNumCheckG == same) //GOOD
                {
                    GameObject _prefab = Instantiate(gPrefab);

                    _prefab.transform.SetParent(GameObject.Find("Canvas").transform);
                    _prefab.transform.localPosition = new Vector3(12f, -490f);

                    GameObject.Find("GoodZone").GetComponent<Good>().Destroy_colObject();
                    StaticHome.goodCount++;
                    ComboPlus();
                    JumPlus(180);
                }
            }
		}
        else
        {
            if (noteNumCheckB == same) //GOOD
            {
                GameObject _prefab = Instantiate(bPrefab);

                _prefab.transform.SetParent(GameObject.Find("Canvas").transform);
                _prefab.transform.localPosition = new Vector3(12f, -490f);

                GameObject.Find("BadZone").GetComponent<Bad>().Destroy_colObject();
                StaticHome.badCount++;
                ComboPlus();
                JumPlus(90);
                ComboReset();
            }
        }

		GameObject.Find("GoodZone").GetComponent<Good>().noteCheck = null;
		GameObject.Find("PerFectZone").GetComponent<Perfect>().noteCheck = null;

		StopCoroutine(OneWait(same));
	}

    IEnumerator JumpWait() //.725초 뒤에 다시 점프 구역 활성화
    {
        yield return new WaitForSeconds(.85f);

        jumpZone.enabled = true;

        StopCoroutine(JumpWait());
    }

	public void ComboPlus()
	{
		comboCount += 1;
		comboText.text = comboCount.ToString();

        if(StaticHome.comboCount < comboCount)
        {
            StaticHome.comboCount = comboCount;
        }

		StartCoroutine(TextAnimation());
	}

	public void ComboReset()
	{
		comboCount = 0;

		comboText.text = "0";

		StartCoroutine(TextAnimation());
	}

	public void JumPlus(int num)
	{
		jumCount += (num + (ComboContFuck()*3)) + (1 + (int)(PlayerPrefs.GetInt("PlayerLevel") * 0.05f));

		string money = string.Format("{0:#,###}", jumCount);

		jumText.text = money;
        StaticHome.scoreCount = jumCount;
    }

    int ComboContFuck()
    {
        if(comboCount == 0)
        {
            return 0;
        }
        else
        {
            return comboCount-1;
        }
    }

	IEnumerator TextAnimation()
	{
		bool returngg = true;
		bool leftright = true;

		while(returngg)
		{
			yield return new WaitForSeconds(.0001f);

			if(leftright)
			{
				comboText.fontSize += 5;

				if(comboText.fontSize >= 180)
				{
					leftright = false;
				}
			}
			else
			{
				comboText.fontSize -= 5;

				if(comboText.fontSize <= 140)
				{
					returngg = false;
				}
			}
		}

		StopCoroutine(TextAnimation());
	}
}
