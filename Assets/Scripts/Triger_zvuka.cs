using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger_zvuka : MonoBehaviour
{
    public AudioSource audio;
    private bool a = false;
    private void OnTriggerEnter(Collider other)
    {
        if(a==false)
        audio.Play();
        a = true;
    }
}
