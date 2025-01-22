using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    /// <summary>
    /// ť�긦 ȸ�� ��Ű�� ��ũ��Ʈ
    /// </summary>


    #region �ʱ� ����
    //  �ڷ���(Type)
    //  ���α׷��� �����͸� �Ǵ��ϴ�  ����
    //  ���� ���Ǵ� �ڷ���
    //  int : ����(integer) - �Ҽ��� ���� ����
    //  float : �Ǽ�(Float) -  �Ҽ����� �ִ� ����
    //  boolean : ��(Boolean) - 0 or 1
    //  string : ���ڿ�(String) - ������ ����(����)

    //  ����(variable)
    //  � Ư�� �� �ϳ��� �����ϱ� ����  �̸��� ���� ���� ����

    //  ����� ���
    //  �ڷ��� ������;

    //  ������ �� ����(�ʱ�ȭ)
    //  ������ ���� �����Ű�� �۾��� �ǹ��Ѵ�.
    //  ������ = ��;





    #endregion

    #region ����
    public float x,y,z;         //����Ƽ �����Ϳ��� �氳�Ǵ� ����
    private float sample;     //����Ƽ �����Ϳ��� �����Ǵ� ����
    #endregion


    #region �Լ�
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = 1f;
        y = 1.1f;
        z = 1.2f;

        sample = 10f;    // ������ ������� ��� �ڵ� ���ο��� �����Ǵ� ��찡 ����.
       //Debug.Log(sample);

        //  ++���� ������ ������ �� ���� ���� ���

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(sample * x * Time.deltaTime, sample * y * Time.deltaTime, sample * z * Time.deltaTime));   // �ҹ��� transform, �빮�� Transform (Ŭ������ ù���ڰ� �빮��, �ҹ��ڴ� ����)
        //  FPS(Frame Per Second) : �ʴ� ������ 
        //  Time.deltaTime : �� �������� �Ϸ���� ���� �ɸ��� �ð�
    }
    #endregion




}
