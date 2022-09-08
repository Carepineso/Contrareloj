using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class RatonesControl : MonoBehaviour
{
    public GameObject[] bunuelos;
    public Transform bunuelo;
    float velocidad_raton= 2.0f;
    int random = 0;
    Vector3 destination;
    NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
        BuscarBunuelos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(destination, bunuelo.position) > 1.0f)
        {
            destination = bunuelo.position;
            agent.destination = destination;

        }
    }

    void BuscarBunuelos()
    {
        bunuelos = GameObject.FindGameObjectsWithTag("Bunuelo");
        bunuelo = bunuelos[Random.Range(0, bunuelos.Length)].transform;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bunuelo"))
        {
            Destroy(other.gameObject);
            BuscarBunuelos();
        }

        if (other.CompareTag("Lanzallamas"))
        {
            Destroy(this.gameObject);
        }
    }
}
