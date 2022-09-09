using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlJuego : MonoBehaviour
{
    public static ControlJuego controlJuego;
    public Text tContRat;
    public int contRat = 0;
    public int contBun = 0;
    // Start is called before the first frame update
    void Awake()
    {
        if (controlJuego == null)
        {
            controlJuego = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    public void ContaRatones()
    {
        contRat++;
        tContRat.text = contRat.ToString("00");
    }

    public void ContaBunuelos()
    {
        contBun++;
    }
}
