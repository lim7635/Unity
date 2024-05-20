using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider slider;
    public AudioClip[] audioClip;

    public AudioSource scenerySource;
    public AudioSource effectSource;

    private void Awake()
    {
        scenerySource.volume = slider.value;
    }

    public void Control(float volume)
    {
        scenerySource.volume = volume;
    }

    public void Sound(int audioValue)
    {
        // PlayOneShot 함수 : 동시에 여러 공간에서 사운드를 출력하는 함수입니다.
        effectSource.PlayOneShot(audioClip[audioValue]);
    }

    void Start()
    {

    }
}