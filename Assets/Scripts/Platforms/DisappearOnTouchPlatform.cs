using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnTouchPlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);

        SoundEffectsManager.instance.PlaySound(SoundEffectsManager.Sounds.CloudPlatform);
    }
}
