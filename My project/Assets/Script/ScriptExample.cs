using UnityEngine;
using UnityEngine.Rendering;


/// <summary>
/// 애니티 애트리뷰트(Unity Attribute) - 꾸미는 용도
/// 에디터에 맞게 스크립트를 커스텀하는 것이 가능
/// </summary>

[AddComponentMenu("CustomUtility/ScriptExaple")]


public class ScriptExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [Range(1, 99)]
    public int Level;

    [Range(0f, 100f)]
    public float Volume;

    [Header("플레이어의 이름")]
    public string player_name;

    [TextArea]
    public string talk01;

    [TextArea(1, 3)]
    public string talk02;

    [TextArea(5, 7)]
    public string talk03;

    [Tooltip("체크되면 죽은 상태")]
    public bool isDead = true;


    //  함수(Function)
    //  C#에서는 크래스 내부에서 설계되는 함수를 
    //  메소드(method)라고 부른다.

    //  함수는 특정 하나의 기능을 수행하기 위한 작성된 명령문 집합체
    //  코드 내에서 설계된 함수는 원하는 작업 위치에서 호출을 통해
    //  사용 할 수 있습니다.

    //  함수의 설계 방법
    //  자료형 함수의 이름(매개변수)
    //{
    //    함수를 호출했을 때, 실행할 명령문을 작성하는 자리;
    //}
    //함수 호출 방법
    //함수 이름(인자)
    //매개변수 : 함수를 호출할 때, 전달 받을 데이터에 대한 표현
    //인자 : 함수를 호출할 때 전달할 값

    //void 효과 데미지(int damage) { 
    //    damage 만큼 데미지를 준다.
    //}
    //효과 데미지(100);
    //위에 만든 효과 데미지 함수가 실행이 됩니다.
    //작성한 인자(100)는 매개변수(damage)에 저장(전달)
    //내부의 코드의 기능을 수앻합니다.
    //damage는 100이기 때문에 100만큼 데미지를 주게 됩니다.
    //작업종료



    [ContextMenu("HelloEveryone")]
    void HelloEveryone()
    {
        Debug.Log("여러분들 모두 안녕하세요.");
    }
    void HelloSomeone(string who)
    {
        Debug.Log($"{ who}님 안녕하세요");
    }
}
