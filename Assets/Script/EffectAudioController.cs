using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectAudioController : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField]
    List<AudioClip> effectWin;
    [SerializeField]
    List<AudioClip> effectLose;
    [SerializeField]
    List<AudioClip> attack;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayWinEffect()
    {
        if (effectWin != null)
        {
            audioSource.clip = effectWin[Random.Range(0, effectWin.Count)];
            audioSource.Play();
        }
    }
    public void PlayLoseEffect()
    {
        if (effectLose != null)
        {
            audioSource.clip = effectLose[Random.Range(0, effectLose.Count)];
            audioSource.Play();
        }
    }
    public void PlayAttactEffect()
    {
        if (attack != null)
        {
            audioSource.clip = attack[Random.Range(0, attack.Count)];
            audioSource.Play();
        }
    }

    public void StopPlay()
    {
        audioSource.Stop();
    }
}
