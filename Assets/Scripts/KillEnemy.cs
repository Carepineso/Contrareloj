using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public Collider coli;
    // Start is called before the first frame update
    void Start()
    {
        coli = GetComponent<BoxCollider>();
        coli.enabled = !coli.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        OnOff();
    }

    void OnOff()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            coli.enabled = coli.enabled;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            coli.enabled = !coli.enabled;
        }
    }
}
