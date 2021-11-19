using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudioController : MonoBehaviour
{
    public int playType = -1;
    AudioSource audioSource;
    [SerializeField]
    List<AudioClip> backgroundWithoutFight;
    [SerializeField]
    List<AudioClip> backgroundInFight;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
     
    }
    public void PlayBackGroundWithoutFight()
    {
        if (backgroundInFight != null && playType!=1)
        {
            audioSource.clip = backgroundWithoutFight[Random.Range(0, backgroundWithoutFight.Count)];
            audioSource.Play();
            playType = 1;
        }
    }
    public void PlayBackGroundWithFight()
    {
        if (backgroundInFight != null && playType!=2)
        {
            audioSource.clip = backgroundInFight[Random.Range(0, backgroundWithoutFight.Count)];
            audioSource.Play();
            playType = 2;
        }
    }
}
