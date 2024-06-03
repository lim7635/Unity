using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 5.0f;
    private Vector3 direction;
    private Rigidbody rigidBody;

    public GameManager gameManager;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (gameManager.State == false) return;

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        // Rigidbody.AddForce : RigidBody�� ���� �� �����̱� ���� �Լ�

        // ForceMode.Force : ª�� �ð��� �߻��ϴ� ��� ��ȭ�� ũ�⸦ ��Ÿ����
        // �ַ� �ٶ��̳� �ڱ��ó�� ���������� �־����� ���� ��Ÿ���� �� ���

        // ForceMode.Impulse : ��ݷ��� RigidBody�� �ִ� ���� ��ݷ��̶� ���� ũ��� �ִ� �ð��� ���� ��ġ��.
        // �ַ� Ÿ���̳� ����ó�� ���������� ���� ��Ÿ���� �� ���

        // ForceMode.Acceleration : RigidBody�� ���� ������ �����ϰ� ���������� ���ӷ��� �ִ� ����.
        // ������ ��� ���� ������ ������ ����� ���� �ַ� ������ �߷� ǥ���� ���.

        // ForceMode.VelocityChange : RigidBody�� ���� ������ �����ϰ� ���������� �ӵ��� ��ȭ�� �ִ� ����.
        // Acceleration�� �ð��� �귯���鼭 ��ȭ�� ����Ű�� �� ���� �� ���� ���������� ������ �ӵ��� ��ȭ�� ����Ŵ.

        rigidBody.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.Impulse);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Collision Enter");
    //}

    //private void OnCollisionStay(Collision collision)
    //{
    //    Debug.Log("Collision Stay");
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    Debug.Log("Collision Exit");
    //}
}