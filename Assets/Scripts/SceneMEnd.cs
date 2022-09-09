using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMEnd : MonoBehaviour
{
    public ControlJuego controlJuego;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
    }

    public void GameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameInicio()
    {
        SceneManager.LoadScene("Incio");
    }
    public void GameOver()
    {
        if (controlJuego.contBun == 4)
        {
            StartCoroutine(ParaEnd());
            SceneManager.LoadScene("End");
        }

    }
    IEnumerator ParaEnd()
    {
        yield return new WaitForSeconds(9.0f);
    }

}
