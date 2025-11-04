using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverHaciaFrente : MonoBehaviour
{
    [SerializeField] float velocidad = 5f;

    void Update()
    {
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Colisión con: " + col.gameObject.name);
        gameObject.SetActive(false); // desactiva el proyectil
    }

}
