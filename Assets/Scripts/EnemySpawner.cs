using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject jet;
    public float startTime;
    private float spawnTime; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnTime <= 0)
        {
            Instantiate(jet, transform.position, Quaternion.identity);

            spawnTime = startTime; 
        } else
        {
            spawnTime -= Time.deltaTime; 
        }
    }
}
