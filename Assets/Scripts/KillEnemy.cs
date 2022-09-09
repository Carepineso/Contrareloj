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
        lanza.Stop();

        /*var main = lanza.main;
        main.loop = false;
        main.duration = 1.0f;
        main.stopAction = ParticleSystemStopAction.Destroy;*/
        //var emission = lanza.emission;
        //emission.enabled=!emission.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        var emission = lanza.emission;
        OnOff();
        if (coli.enabled)
        {
            dispara = true;
            lanza.Play();

        }
        else
        {
            dispara = false;
            lanza.Stop();
         
        }
    }

    

    void OnOff()
    {
        //var emission = lanza.emission;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            coli.enabled = coli.enabled;

            //emission.enabled = emission.enabled;

        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            coli.enabled = !coli.enabled;
            //emission.enabled = !emission.enabled;
        }
    }
}
