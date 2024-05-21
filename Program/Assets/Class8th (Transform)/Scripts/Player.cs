using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 1.0f;

    void Start()
    {
        // Boxing
        // 값 형식의 데이터를 참조 형식으로 변환하는 과정입니다.
        object data = speed;

        Debug.Log("data의 값 : " + data);

        // UnBoxing
        // 참조 형식의 데이터를 값 형식으로 변환하는 과정입니다.
        float result = (float)data;

        Debug.Log("result 변수의 값 : " + result);
    }

    void Update()
    {
        #region Input 클래스
        // 키보드 입력 함수

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, 0, 1);
        //}
        //else if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.position += new Vector3(-1, 0, 0);
        //}
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, 0, -1);
        //}
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.position += new Vector3(1, 0, 0);
        //}
        #endregion

        #region GetAxis 클래스

        direction.x = Input.GetAxisRaw("Horizontal"); // 수평 정보 값
        direction.z = Input.GetAxisRaw("Vertical"); // 수직 정보 값

        // Time.deltaTime : 한 프레임 당 실행하는 시간

        // 벡터의 정규화 : 벡터의 크기를 1로 설정하여 대각선 이동을 균일하게 처리하도록 설정합니다.
        direction.Normalize();

        transform.position += direction * speed * Time.deltaTime; // P = P0 + vt

        #endregion
    }
}