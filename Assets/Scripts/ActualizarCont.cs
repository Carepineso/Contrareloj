using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarCont : MonoBehaviour
{
    public Text textCont;
    // Start is called before the first frame update
    void Start()
    {
        textCont.text = PlayerPrefs.GetInt("Ratones", 0).ToString("00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
