using System;
using UnityEngine;

[Flags]
public enum DAY
{
    None = 0,
    �� = 1 << 0,
    �� = 1 << 1,
    ȭ = 1 << 2,
    �� = 1 << 3,
    �� = 1 << 4,
    �� = 1 << 5,
    �� = 1 << 6
}

public enum JOB
{
    ������,
    ��������,
    ��������2,
    ��������3,
    ��������5,
}


public class DataExample : MonoBehaviour
{

    public string[] schedules;
    public DAY work_day;
    public JOB job;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(work_day);
        Debug.Log(job);

        //������ ��ü�� ������ ���
        for (int i = 0; i < schedules.Length; i++) { 
            Debug.Log("���� : " + schedules[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
