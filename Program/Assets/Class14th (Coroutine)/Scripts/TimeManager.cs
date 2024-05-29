using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    WaitForSeconds waitForSeconds = new WaitForSeconds(3); // 참조 변수 (3초 뒤 실행)
    
    void Start()
    {
        StartCoroutine(Routine());
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StopAllCoroutines();
        }
    }

    public IEnumerator Routine()
    {
        while (true)
        {
            Debug.Log("Start");

            yield return waitForSeconds; // 캐싱

            Debug.Log("Coroutine");
        }
    }
}