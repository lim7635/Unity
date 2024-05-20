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
        // PlayOneShot �Լ� : ���ÿ� ���� �������� ���带 ����ϴ� �Լ��Դϴ�.
        effectSource.PlayOneShot(audioClip[audioValue]);
    }

    void Start()
    {

    }
}