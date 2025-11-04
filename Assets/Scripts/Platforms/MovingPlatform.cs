using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] float maximumHigh;

    [SerializeField] float minimumHigh;

    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > maximumHigh)
            speed *= -1f;

        if (transform.position.y < minimumHigh)
            speed *= -1f;

        transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawLine(new Vector3(transform.position.x, maximumHigh, transform.position.z), new Vector3(transform.position.x, minimumHigh, transform.position.z));
    }
}
