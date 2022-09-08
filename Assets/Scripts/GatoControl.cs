using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatoControl : MonoBehaviour
{
   public float velocidad = 2.0f;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(joystick.Horizontal * velocidad * Time.deltaTime, 0, joystick.Vertical * velocidad * Time.deltaTime);
    }
}
