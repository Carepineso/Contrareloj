using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaBunuelo : MonoBehaviour
{
    public float vidaMax = 100;
    

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Raton") && vidaMax >= 0)
        {
            vidaMax = vidaMax - 0.5f;
            if (vidaMax == 0)
            {
                Destroy(this.gameObject);
            }

        }
    }
}
