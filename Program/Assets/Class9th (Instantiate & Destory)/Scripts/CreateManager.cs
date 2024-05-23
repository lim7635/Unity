using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    public Factory factory;

    private void Awake()
    {
        factory = GetComponent<Factory>();
    }

    void Start()
    {
        // Invoke() : Ư���� �ð����� �Լ��� ȣ���ϴ� �Լ��Դϴ�.

        InvokeRepeating(nameof(Use), 1, 5); // 1�� �� ���� �� 5�� ���� ���� �ݺ�
    }

    public void Use()
    {
        int select = Random.Range(0, 2);

        factory.Create((UnitType)select);
    }
}