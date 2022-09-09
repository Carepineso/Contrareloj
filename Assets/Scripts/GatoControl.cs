using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatoControl : MonoBehaviour
{
    public float velocidad = 5.0f;
    public Joystick joystick;
    public float angulo;
    public Animator aniGato;
    public KillEnemy killEnemy;


    // Start is called before the first frame update
    void Start()
    {
        aniGato = GetComponentInChildren<Animator>();
        killEnemy = FindObjectOfType<KillEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        aniGato.SetBool("Dispara", killEnemy.dispara);

        if (killEnemy.dispara == true)
        {
            velocidad = velocidad * 0;
        }
        else
        {
            velocidad = 5.0f;
        }

        transform.Translate(joystick.Horizontal * velocidad * Time.deltaTime, 0, joystick.Vertical * velocidad * Time.deltaTime,Space.World);
        Vector3 direccion = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        if (direccion.magnitude>0.1f)
        {
            transform.forward = direccion;
            aniGato.SetBool("Mueve", true);
        }
        else
        {
            aniGato.SetBool("Mueve", false);
        }
    }
}
