using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatoControl : MonoBehaviour
{
    public float velocidad = 2.0f;
    public Joystick joystick;
    public float angulo;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(joystick.Horizontal * velocidad * Time.deltaTime, 0, joystick.Vertical * velocidad * Time.deltaTime,Space.World);
        Vector3 direccion = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        if (direccion.magnitude>0.1f)
        {
            transform.forward = direccion;
        }
    }
}
