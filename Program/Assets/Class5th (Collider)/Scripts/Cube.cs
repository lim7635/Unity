using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IDamageable
{
    private int health = 100;

    // OnCollisionEnter �Լ�
    // �������� �浹�� ���� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    // OnCollisionStay �Լ�
    // �������� �浹�� �ϰ� ���� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }

    // OnCollisionExit �Լ�
    // �������� �浹�� ������ �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }

    public void Active()
    {
        health -= 50;

        Debug.Log("Damage�� �޾ҽ��ϴ�.");
    }
}