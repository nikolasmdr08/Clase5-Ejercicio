using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPlatform : MonoBehaviour
{
    [SerializeField] float jumpingForce;

    private void OnCollisionEnter2D(Collision2D collision)
    { 
        if(collision.gameObject.GetComponent<Rigidbody2D>())
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpingForce, ForceMode2D.Impulse);

            SoundEffectsManager.instance.PlaySound(SoundEffectsManager.Sounds.JumpingPlatform);
        }
    }
}
