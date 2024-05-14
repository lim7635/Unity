using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    // Awake 함수
    // 게임 오브젝트가 인스턴스된 후에 단 한 번만 호출되며
    // 스크립트가 비활성화되었을 때도 호출되는 이벤트 함수입니다.
    // 서버 데이터를 가져올 때 사용
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // OnEnable 함수
    // 게임 오브젝트가 활성화되었을 때 호출되는 이벤트 함수입니다.
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // Start 함수
    // 게임 오브젝트가 인스턴스된 후에 단 한 번만 호출되며
    // 스크립트가 활성화되었을 때만 호출되는 이벤트 함수입니다.
    void Start()
    {
        Debug.Log("Start");
    }

    // FixedUpdate 함수
    // TimeStep(Default : 0.02초)에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 함수입니다.
    // 물리 엔진이 들어갈 때 사용
    private void FixedUpdate()
    {
        Debug.Log("Fixed Update");
    }

    // Update 함수
    // 매 프레임마다 호출되는 이벤트 함수입니다.
    // 입력이 필요할 때 사용
    void Update()
    {
        Debug.Log("Update");
    }

    // LateUpdate 함수
    // Update 함수가 끝난 후에 호출되는 이벤트 함수입니다.
    // 카메라 연출이 필요할 때 사용
    private void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    // OnDisable 함수
    // 게임 오브젝트가 비활성화되었을 때 호출되는 이벤트 함수입니다.
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    // OnDestroy 함수
    // 게임 오브젝트가 파괴되었을 때 호출되는 이벤트 함수입니다.
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}