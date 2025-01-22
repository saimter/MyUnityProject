//  using은 다음에 적힌 것을 코드에서 사용중이라는 뜻
//  유니티에서 유니티를 활용해 작업하는 스크립트라면 아래의 코드를 반드시 추가
using UnityEngine;


//  UnityTutorial ㅕㅇㅇ역에서  만들어진 SampleA 클래스
namespace UnityTutorial
{
    public class SampleA
    {

    }
}

//  네임 스페이스는 특정 기능을 하는 클래스의 대표적인 이름으로써 사용
namespace TowerDefence
{
    public class PlaySetting
    {

    }
}

public class SampleA
{

}
/// <summary>
/// 처음으로 만들어본 유니티 스크립트
/// </summary>


public class test : MonoBehaviour

    //MonoBehavior는 클래스에 연결했을 경우
    // 유니티 씬에 존재하는 오브젝트에 스크립트를 연결 할 수 있게 해줍니다.
    // 추가적으로 유니티에서 제공해주는 기능을 사용 할 대 사용
{

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
    }

    int count = 0;



    // Update is called once per frame
    void Update()
    {
        //Debug.Log($"{count}"); // $를 쓰면 문장안에 숫자를 쓸 수 있다.
        count++;
    }
}
