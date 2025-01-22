using UnityEngine;
using UnityEngine.Rendering;


/// <summary>
/// �ִ�Ƽ ��Ʈ����Ʈ(Unity Attribute) - �ٹ̴� �뵵
/// �����Ϳ� �°� ��ũ��Ʈ�� Ŀ�����ϴ� ���� ����
/// </summary>

[AddComponentMenu("CustomUtility/ScriptExaple")]


public class ScriptExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [Range(1, 99)]
    public int Level;

    [Range(0f, 100f)]
    public float Volume;

    [Header("�÷��̾��� �̸�")]
    public string player_name;

    [TextArea]
    public string talk01;

    [TextArea(1, 3)]
    public string talk02;

    [TextArea(5, 7)]
    public string talk03;

    [Tooltip("üũ�Ǹ� ���� ����")]
    public bool isDead = true;


    //  �Լ�(Function)
    //  C#������ ũ���� ���ο��� ����Ǵ� �Լ��� 
    //  �޼ҵ�(method)��� �θ���.

    //  �Լ��� Ư�� �ϳ��� ����� �����ϱ� ���� �ۼ��� ��ɹ� ����ü
    //  �ڵ� ������ ����� �Լ��� ���ϴ� �۾� ��ġ���� ȣ���� ����
    //  ��� �� �� �ֽ��ϴ�.

    //  �Լ��� ���� ���
    //  �ڷ��� �Լ��� �̸�(�Ű�����)
    //{
    //    �Լ��� ȣ������ ��, ������ ��ɹ��� �ۼ��ϴ� �ڸ�;
    //}
    //�Լ� ȣ�� ���
    //�Լ� �̸�(����)
    //�Ű����� : �Լ��� ȣ���� ��, ���� ���� �����Ϳ� ���� ǥ��
    //���� : �Լ��� ȣ���� �� ������ ��

    //void ȿ�� ������(int damage) { 
    //    damage ��ŭ �������� �ش�.
    //}
    //ȿ�� ������(100);
    //���� ���� ȿ�� ������ �Լ��� ������ �˴ϴ�.
    //�ۼ��� ����(100)�� �Ű�����(damage)�� ����(����)
    //������ �ڵ��� ����� �����մϴ�.
    //damage�� 100�̱� ������ 100��ŭ �������� �ְ� �˴ϴ�.
    //�۾�����



    [ContextMenu("HelloEveryone")]
    void HelloEveryone()
    {
        Debug.Log("�����е� ��� �ȳ��ϼ���.");
    }
    void HelloSomeone(string who)
    {
        Debug.Log($"{ who}�� �ȳ��ϼ���");
    }
}
