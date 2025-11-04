using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;

    [SerializeField] float horizontalSpeed = 2.0f;

    void FixedUpdate()
    {
#if UNITY_EDITOR
        float h = horizontalSpeed * Input.GetAxis("Horizontal");
#elif UNITY_ANDROID
        float h = horizontalSpeed * Input.acceleration.x;
#endif
        rigidbody.AddForce(Vector2.right * h);
    }
}