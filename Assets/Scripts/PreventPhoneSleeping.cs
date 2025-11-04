using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventPhoneSleeping : MonoBehaviour
{
#if UNITY_ANDROID
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
#endif
}
