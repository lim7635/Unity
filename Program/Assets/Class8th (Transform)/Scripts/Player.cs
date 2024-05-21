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
        // �� ������ �����͸� ���� �������� ��ȯ�ϴ� �����Դϴ�.
        object data = speed;

        Debug.Log("data�� �� : " + data);

        // UnBoxing
        // ���� ������ �����͸� �� �������� ��ȯ�ϴ� �����Դϴ�.
        float result = (float)data;

        Debug.Log("result ������ �� : " + result);
    }

    void Update()
    {
        #region Input Ŭ����
        // Ű���� �Է� �Լ�

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

        #region GetAxis Ŭ����

        direction.x = Input.GetAxisRaw("Horizontal"); // ���� ���� ��
        direction.z = Input.GetAxisRaw("Vertical"); // ���� ���� ��

        // Time.deltaTime : �� ������ �� �����ϴ� �ð�

        // ������ ����ȭ : ������ ũ�⸦ 1�� �����Ͽ� �밢�� �̵��� �����ϰ� ó���ϵ��� �����մϴ�.
        direction.Normalize();

        transform.position += direction * speed * Time.deltaTime; // P = P0 + vt

        #endregion
    }
}