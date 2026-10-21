using UnityEngine;

public class PojavaDuha : MonoBehaviour
{
    public GameObject duh;

    private bool aktivirano;

    private void OnTriggerEnter(Collider other)
    {
        if (aktivirano || !other.CompareTag("Player"))
            return;

        if (duh == null)
        {
            return;
        }

        duh.SetActive(true);
        aktivirano = true;
    }
}
