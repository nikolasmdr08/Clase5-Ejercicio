using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsManager : MonoBehaviour
{
    public static SoundEffectsManager instance;

    public void Awake()
    {
        if (!instance)
            instance = this;
        else
            return;

        DontDestroyOnLoad(gameObject);
    }

    public enum Sounds
    {
        JumpingPlatform,
        DeathPlatform,
        CloudPlatform,
        DisappearPlatform,
        AppearPlatform,
        Gem,
    }

    public AudioClip[] audioClips;

    public void PlaySound(Sounds sound)
    {
        StartCoroutine(WaitingReproduction(new GameObject().AddComponent<AudioSource>(), sound));
    }

    IEnumerator WaitingReproduction(AudioSource audioSource, Sounds sound)
    {
        audioSource.gameObject.transform.SetParent(transform);

        audioSource.clip = audioClips[(int)sound];
        audioSource.Play();

        while (audioSource.isPlaying)
            yield return null;

        Destroy(audioSource.gameObject);
    }
}
