using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    // Awake �Լ�
    // ���� ������Ʈ�� �ν��Ͻ��� �Ŀ� �� �� ���� ȣ��Ǹ�
    // ��ũ��Ʈ�� ��Ȱ��ȭ�Ǿ��� ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    // ���� �����͸� ������ �� ���
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // OnEnable �Լ�
    // ���� ������Ʈ�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // Start �Լ�
    // ���� ������Ʈ�� �ν��Ͻ��� �Ŀ� �� �� ���� ȣ��Ǹ�
    // ��ũ��Ʈ�� Ȱ��ȭ�Ǿ��� ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    void Start()
    {
        Debug.Log("Start");
    }

    // FixedUpdate �Լ�
    // TimeStep(Default : 0.02��)�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    // ���� ������ �� �� ���
    private void FixedUpdate()
    {
        Debug.Log("Fixed Update");
    }

    // Update �Լ�
    // �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    // �Է��� �ʿ��� �� ���
    void Update()
    {
        Debug.Log("Update");
    }

    // LateUpdate �Լ�
    // Update �Լ��� ���� �Ŀ� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    // ī�޶� ������ �ʿ��� �� ���
    private void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    // OnDisable �Լ�
    // ���� ������Ʈ�� ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    // OnDestroy �Լ�
    // ���� ������Ʈ�� �ı��Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}