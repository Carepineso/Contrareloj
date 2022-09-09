using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public Collider coli;
    public bool dispara = false;
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
        if (coli.enabled)
        {
            dispara = true;
        }
        else
        {
            dispara = false;
        }
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
