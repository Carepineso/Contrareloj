using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class KillEnemy : MonoBehaviour
{
    public Collider coli;
    public ParticleSystem lanza;
    public bool dispara = false;
    
    // Start is called before the first frame update
    void Start()
    {
        coli = GetComponent<BoxCollider>();
        coli.enabled = !coli.enabled;
        lanza = GetComponent<ParticleSystem>();

        

        
       
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
            OnOff2();

        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            coli.enabled = !coli.enabled;
           

        }
    }

    public void OnOff2()
    {
        coli.enabled = !coli.enabled;
        dispara = coli.enabled;
        if (dispara)
        {
            lanza.Play();
        }
        else
        {
            lanza.Stop();
        }
    }
}
