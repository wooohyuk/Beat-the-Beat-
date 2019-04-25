using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMan_Control : MonoBehaviour
{
    public Animator anim; //스틱맨 에니메이터

    private Coroutine animWaitAndEndCoroutine;

    public BoxCollider2D missZone; //롱노트 시작 시 비활성화

    public GameObject mPrefab;

    public bool clickLol;   // 클릭이 활성화 되어있는지 여부 (대부분 None노트 떄문에 ㅆㅂ)
    public bool longAttacking; //롱 공격중인지 (애니메이션 실행중인지)
    bool jumpAni;

    float firstX, firstY;   // 시작 좌표
    float finishX, finishY; // 끝 좌표
    float totalX, totalY;   // 결과값 좌표  

    void Start()
    {
        animWaitAndEndCoroutine = null;
        missZone = GameObject.Find("MissZone").GetComponent<BoxCollider2D>();
        missZone.enabled = true;
        clickLol = true;    // 클릭 가능
        jumpAni = false;
        longAttacking = false;  // 롱 노트 공격중이 아님
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))    //터치했을 때
        {
            firstX = Input.mousePosition.x;
            firstY = Input.mousePosition.y;

            if (GameObject.Find("LongZone").GetComponent<LongScript>().longIn) // 구역안에 롱노트가 들어왔다면 
            {
                longAttacking = true;   // 롱노트 공격모션 True
                missZone.enabled = false;
                StartOnlyOnecCoroutine(0.7f, "Long_CheckF");
                return;
            }
        }

        if (Input.GetMouseButton(0))    //터치중일때
        {
            if (longAttacking) //롱 공격 모션중이라면 리턴
            {
                firstX = Input.mousePosition.x;
                firstY = Input.mousePosition.y;
                return;
            }

            finishX = Input.mousePosition.x;
            finishY = Input.mousePosition.y;

            totalX = Mathf.Abs(firstX - finishX);
            totalY = Mathf.Abs(firstY - finishY);

            if (totalX >= 200)
            {
                if (totalY <= 200)
                {
                    if (firstX > finishX) //오른쪽에서 왼쪽
                    {
                        StartOnlyOnecCoroutine(0.267f, "Left_Check");
                    }
                    else //왼쪽에서 오른쪽
                    {
                        StartOnlyOnecCoroutine(0.333f, "Right_Check");
                    }
                }
            }
            else if (totalY >= 60)
            {
                if (totalX <= 100)
                {
                    if (firstY > finishY) //위에서 아래
                    {

                    }
                    else //아래에서 위
                    {
                        StartOnlyOnecCoroutine(0.85f, "Jump_Check");
                    }
                }
            }
            else
            {
                
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (clickLol)
            {
                StartOnlyOnecCoroutine(0.367f, "None_Check");
            }
            else
            {
                clickLol = true;
            }

            if (longAttacking)
            {
                StartOnlyOnecCoroutine(0.333f, "Long_CheckS");

                GameObject _prefab = Instantiate(mPrefab);

                _prefab.transform.SetParent(GameObject.Find("Canvas").transform);
                _prefab.transform.localPosition = new Vector3(12f, -490f);

                GameObject.Find("LongZone").GetComponent<LongScript>().LongOut();
                GameObject.Find("LongZone").GetComponent<LongScript>().LongDestroy();
                StaticHome.missCount++;
                GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().ComboReset();
            }
        }
    }

    public void StartOnlyOnecCoroutine(float waitTime, string whatAnimation)
    {
        if(jumpAni) //점프도중일때 리턴
        {
            return;
        }

        if(anim.GetBool(whatAnimation) == true) //기존 Bool 값과 현재가 일치하는지 (연타)
        {
            if(DoubleAttack(whatAnimation) == "Nop") // 왼쪽, 오른쪽, 기본공격 제외는 ㅃㅃ
            {

            }
            else // 왼쪽 오른쪽 기본공격일 때
            {
                anim.Play(DoubleAttack(whatAnimation),-1,0);    
                AttackArea(whatAnimation);
                return;
            }
        }

        if(animWaitAndEndCoroutine != null)
        {
            StopCoroutine(animWaitAndEndCoroutine);
        }
        SetAnimBoolonlyThis(whatAnimation);
        animWaitAndEndCoroutine = StartCoroutine(WaitAndEndAnimation(waitTime, whatAnimation));

        if (whatAnimation == "Jump_Check")
        {
            Debug.Log("점프애니 트루");
            jumpAni = true;
        }
    }

    IEnumerator WaitAndEndAnimation(float waitTime, string whatAnimation)
    {
        yield return new WaitForSeconds(waitTime);
        SetAnimBoolonlyThis("Run_Check");
    }

    public void SetAnimBoolonlyThis(string whatBool)
    {
        if(jumpAni) //점프중이면
        {
            if(whatBool == "Run_Check") //만약 Run_Check로 되돌아오면
            {
                Debug.Log("점프애니 펄스");
                jumpAni = false;
            }
            else
            {
                return;
            }
        }

        if(longAttacking)
        {
            if(whatBool == "Long_CheckF")
            {

            }
            else if(whatBool == "Long_CheckS")
            {
                missZone.enabled = true;
            }
            else
            {
                return;
            }
        }

        anim.SetBool("Run_Check", false);
        anim.SetBool("Left_Check", false);
        anim.SetBool("Right_Check", false);
        anim.SetBool("None_Check", false);
        anim.SetBool("Jump_Check", false);
        anim.SetBool("Long_CheckS", false);
        anim.SetBool("Long_CheckF", false);

        if(whatBool != "None_Check")
        {
            if(whatBool != "Run_Check")
            {
                clickLol = false;
            }
        }

        anim.SetBool(whatBool, true);
        AttackArea(whatBool);

        if (whatBool == "Long_CheckS")
        {
            longAttacking = false;
        }
    }

    void AttackArea(string whatBool)
    {
        if(whatBool == "Left_Check")
        {
            GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().DestroyNote(1);
        }
        else if(whatBool == "Right_Check")
        {
            GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().DestroyNote(2);
        }
        else if (whatBool == "None_Check")
        {
            GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().DestroyNote(3);
        }
        else if (whatBool == "Jump_Check")
        {
            GameObject.Find("DeterChecker").GetComponent<Judgment_Manage>().JumpEvasionFalse();
        }
    }

    string DoubleAttack(string whatBool)
    {
        if (whatBool == "Left_Check")
        {
            return "Left_Attack";
        }
        else if (whatBool == "Right_Check")
        {
            return "Right_Attack";
        }
        else if (whatBool == "None_Check")
        {
            return "None_Attack";
        }
        else
        {
            return "Nop";
        }
    }
}

/*
 *
 *1. 장애물
 * 2. 좌노트
 * 3. 우노트
 * 4. 탭노트
 * 5. 연타노트
 * 6. 롱 노트
 * */
