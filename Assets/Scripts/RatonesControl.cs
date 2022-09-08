using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class RatonesControl : MonoBehaviour
{
    public GameObject[] bunuelos;
    public Transform bunuelo;
    int random = 0;
    Vector3 destination;
    NavMeshAgent agent;
    public estados estado;
    public GameObject[] killPoints;
    public Transform killPoint;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        destination = agent.destination;
        BuscarBunuelos();
    }

    // Update is called once per frame
    void Update()
    {
        switch (estado)
        {
            case estados.vivo:
                if (Vector3.Distance(destination, bunuelo.position) > 1.0f)
                {
                    if (bunuelo!=null)
                    {
                        destination = bunuelo.position;
                    }
                    agent.destination = destination;

                }
                break;
            case estados.muerto:
                agent.destination = killPoint.position;
                break;
            default:
                break;
        }

    }

    void BuscarBunuelos()
    {
        bunuelos = GameObject.FindGameObjectsWithTag("Bunuelo");
        bunuelo = bunuelos[Random.Range(0, bunuelos.Length)].transform;
        animator.SetBool("Comer", false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bunuelo"))
        {
            Destroy(other.gameObject,5);
            bunuelo = other.transform;
            animator.SetBool("Comer", true);
            Invoke("BuscarBunuelos", 5f);
        }

        if (other.CompareTag("Lanzallamas"))
        {
            killPoints = GameObject.FindGameObjectsWithTag("Creador");
            killPoint = killPoints[Random.Range(0,killPoints.Length)].transform;
            agent.speed = agent.speed * 2;
            animator.SetBool("Vivo", false);
            estado = estados.muerto;
        }
    }
}
public enum estados
{
    vivo, 
    muerto
}
