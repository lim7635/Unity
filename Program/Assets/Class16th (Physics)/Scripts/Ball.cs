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
        // Rigidbody.AddForce : RigidBody에 힘을 줘 움직이기 위한 함수

        // ForceMode.Force : 짧은 시간에 발생하는 운동량 변화의 크기를 나타내며
        // 주로 바람이나 자기력처럼 연속적으로 주어지는 힘을 나타내는 데 사용

        // ForceMode.Impulse : 충격량을 RigidBody에 주는 모드로 충격량이랑 힘의 크기와 주는 시간을 곱한 수치다.
        // 주로 타격이나 폭팔처럼 순간적으로 힘을 나타내는 데 사용

        // ForceMode.Acceleration : RigidBody가 갖는 질량을 무시하고 직접적으로 가속량을 주는 모드다.
        // 질량에 상관 없이 일정한 가속을 만들어 내며 주로 지구의 중력 표현에 사용.

        // ForceMode.VelocityChange : RigidBody가 가진 질량을 무시하고 직접적으로 속도의 변화를 주는 모드다.
        // Acceleration은 시간이 흘러가면서 변화를 일으키는 데 비해 이 모드는 순간적으로 지정한 속도로 변화를 일으킴.

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