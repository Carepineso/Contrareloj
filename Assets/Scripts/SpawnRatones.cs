using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRatones : MonoBehaviour
{
    public Transform[] spawnPaints;
    public GameObject prefabEnemy;
    private int random = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TSpawn());
    }

    IEnumerator TSpawn()
    {

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2.0f, 8.0f));
            random = Random.Range(0, spawnPaints.Length);
            GameObject gameObject = Instantiate<GameObject>(prefabEnemy, spawnPaints[random].position, Quaternion.identity);
        }
    }
}
