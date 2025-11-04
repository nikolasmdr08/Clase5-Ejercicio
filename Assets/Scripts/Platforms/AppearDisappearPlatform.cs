using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearDisappearPlatform : MonoBehaviour
{
    [SerializeField] float time;

    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.activeSelf == true)
            gameObject.SetActive(false);
        else
            gameObject.SetActive(true);

        Invoke("Start", time);

        SoundEffectsManager.instance.PlaySound(SoundEffectsManager.Sounds.AppearPlatform);
    }
}
