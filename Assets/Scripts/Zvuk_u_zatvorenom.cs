using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zvuk_u_zatvorenom : MonoBehaviour
{
    public AudioSource a;
    public AudioSource[] zvukovi;
   
    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < zvukovi.Length; i++)
        {
            a = zvukovi[i];
            a.volume = 0.2f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < zvukovi.Length; i++)
        {
            a = zvukovi[i];
            a.volume = 1f;
        }
    }
}
