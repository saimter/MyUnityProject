using UnityEngine;

public enum RAINBOW
{
    빨강색,
    주황색,
    노랑색,
    초록색,
    파란색,
    남색,
    보라색
}


[AddComponentMenu("Custom_GS/gsKim")]



public class gsKim : MonoBehaviour
{

    public bool isJump = true;

    public string[] basket_fruit;

    public int money = 0;

    [Range(1, 99)]
    public int fieldView;

    public RAINBOW rainbow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
