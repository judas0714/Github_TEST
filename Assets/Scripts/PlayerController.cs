using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //플레이어 이동 구현
    //1. Transform.position
    //2. Transform.Translate()
    //3. Vector3.MoveTowards   

    float moveSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //플레이어 이동
        Move1();
        Move2();
        Move3();
        Move4();
    }

    void Move1()
    {
        // 1. 입력 받기 (키보드, 마우스 등 입력은 Input 매니저가 담당한다)
        // Input.GetAxis("Horizontal") -1 ~ 1       (실수)
        // Input.GetAxisRaw("Horizontal") -1 ~ 1    (정수)

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // 2. 이동 벡터 만들기
        Vector3 dir = new Vector3(moveX, moveY, 0); // z축은 0으로 고정

        // 3. 방향 벡터 정규화 (대각선 이동시 속도 보정)
        // dir = dir.normalized;
        dir.Normalize();

        // 4. 이동
        //Vector3 pos = transform.position + dir * moveSpeed * Time.deltaTime;
        //transform.position = pos;
        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    void Move2()
    {

    }

    void Move3()
    {

    }

    void Move4()
    {

    }
}
