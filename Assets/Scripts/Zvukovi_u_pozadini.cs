using System.Collections;
using UnityEngine;

public class Zvukovi_u_pozadini : MonoBehaviour
{
    public AudioSource a_s;
    public AudioClip[] a_c_niz;

    [Header("Random sound interval (seconds)")]
    [Min(0.1f)] public float minDelay = 20f;
    [Min(0.1f)] public float maxDelay = 50f;

    private void Awake()
    {
        if (a_s == null)
            a_s = GetComponent<AudioSource>();
    }

    private void Start()
    {
        if (a_s == null)
        {
            return;
        }

        if (a_c_niz == null || a_c_niz.Length == 0)
        {
            return;
        }

        a_s.spatialBlend = 0f;

        StartCoroutine(Vreme());
    }

    private IEnumerator Vreme()
    {
        while (true)
        {
            float min = Mathf.Max(0.1f, minDelay);
            float max = Mathf.Max(min, maxDelay);
            yield return new WaitForSeconds(Random.Range(min, max));

            AudioClip clip = a_c_niz[Random.Range(0, a_c_niz.Length)];
            if (clip != null)
                a_s.PlayOneShot(clip);
        }
    }
}
