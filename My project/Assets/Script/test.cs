//  using�� ������ ���� ���� �ڵ忡�� ������̶�� ��
//  ����Ƽ���� ����Ƽ�� Ȱ���� �۾��ϴ� ��ũ��Ʈ��� �Ʒ��� �ڵ带 �ݵ�� �߰�
using UnityEngine;


//  UnityTutorial �Ť���������  ������� SampleA Ŭ����
namespace UnityTutorial
{
    public class SampleA
    {

    }
}

//  ���� �����̽��� Ư�� ����� �ϴ� Ŭ������ ��ǥ���� �̸����ν� ���
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
/// ó������ ���� ����Ƽ ��ũ��Ʈ
/// </summary>


public class test : MonoBehaviour

    //MonoBehavior�� Ŭ������ �������� ���
    // ����Ƽ ���� �����ϴ� ������Ʈ�� ��ũ��Ʈ�� ���� �� �� �ְ� ���ݴϴ�.
    // �߰������� ����Ƽ���� �������ִ� ����� ��� �� �� ���
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
        //Debug.Log($"{count}"); // $�� ���� ����ȿ� ���ڸ� �� �� �ִ�.
        count++;
    }
}
