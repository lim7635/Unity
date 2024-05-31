using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void Active();
}

public class EffectZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) // Other Cube를 매개 변수로 가져옴
    {
        // other.gameObject.SetActive(false); // 비활성화 처리

        IDamageable damageable = other.GetComponent<IDamageable>();

        if(damageable != null)
        {
            damageable.Active();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Other Cube"))
        {
            Debug.Log("OnTriggerStay");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Other Cube"))
        {
            Debug.Log("OnTriggerExit");
        }
    }
}