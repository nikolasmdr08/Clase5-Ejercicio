using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Temporizador : MonoBehaviour
{
    [SerializeField] float timer = 30f;
    [SerializeField] TMP_Text text;

    void Update()
    {
        timer -= Time.deltaTime;
        Debug.Log("Timpo actual: " + timer);
        text.text = timerString(timer);
        if (timer <= 0f)
        {
            endTime();
        }
    }

    private string timerString(float timer)
    {
        int minutos = (int)(timer / 60);
        int segundos = (int)(timer % 60);
        return $"{minutos:D2}:{segundos:D2}";
    }

    private void endTime()
    {
        Debug.Log("¡Tiempo agotado!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SoundEffectsManager.instance.PlaySound(SoundEffectsManager.Sounds.DeathPlatform);
    }
}
