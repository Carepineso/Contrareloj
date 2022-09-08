using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatonesControl : MonoBehaviour
{
    public Transform[] quesos;
    float velocidad_raton= 2.0f;
    int random = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        random = Random.Range(0, quesos.Length);
        transform.Translate(quesos[random].position * velocidad_raton * Time.deltaTime);
    }
}
