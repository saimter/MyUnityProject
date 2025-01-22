using System;
using UnityEngine;

[Flags]
public enum DAY
{
    None = 0,
    일 = 1 << 0,
    월 = 1 << 1,
    화 = 1 << 2,
    수 = 1 << 3,
    목 = 1 << 4,
    금 = 1 << 5,
    토 = 1 << 6
}

public enum JOB
{
    직장인,
    프리랜서,
    프리랜서2,
    프리랜서3,
    프리랜서5,
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

        //스테줄 전체의 내용을 출력
        for (int i = 0; i < schedules.Length; i++) { 
            Debug.Log("직업 : " + schedules[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
