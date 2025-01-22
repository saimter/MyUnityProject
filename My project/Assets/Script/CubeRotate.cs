using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    /// <summary>
    /// 큐브를 회전 시키는 스크립트
    /// </summary>


    #region 필기 내용
    //  자료형(Type)
    //  프로그램이 데이터를 판단하는  기준
    //  자주 사용되는 자료형
    //  int : 정수(integer) - 소수점 없는 숫자
    //  float : 실수(Float) -  소수점이 있는 숫자
    //  boolean : 논리(Boolean) - 0 or 1
    //  string : 문자열(String) - 문자의 집합(묶음)

    //  변수(variable)
    //  어떤 특정 값 하나를 저장하기 위해  이름을 붙인 저장 공간

    //  만드는 방법
    //  자료형 변수명;

    //  변수의 값 설정(초기화)
    //  변수에 값을 적용시키는 작업을 의미한다.
    //  변수명 = 값;





    #endregion

    #region 변수
    public float x,y,z;         //유니티 에디터에서 경개되는 변수
    private float sample;     //유니티 에디터에서 공개되는 변수
    #endregion


    #region 함수
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = 1f;
        y = 1.1f;
        z = 1.2f;

        sample = 10f;    // 변수가 비공개일 경우 코드 내부에서 설정되는 경우가 많다.
       //Debug.Log(sample);

        //  ++없이 변수만 적으면 그 값이 들어가는 방식

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(sample * x * Time.deltaTime, sample * y * Time.deltaTime, sample * z * Time.deltaTime));   // 소문자 transform, 대문자 Transform (클래스는 첫문자가 대문자, 소문자는 변수)
        //  FPS(Frame Per Second) : 초당 프레임 
        //  Time.deltaTime : 전 프레임이 완료되지 까지 걸리는 시간
    }
    #endregion




}
