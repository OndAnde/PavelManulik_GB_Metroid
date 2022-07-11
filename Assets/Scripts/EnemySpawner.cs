using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject enemy;
    [SerializeField] private float spawnStep = 1f;

    private float timeToSpawn;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Time.time > timeToSpawn)
        {
            
            Instantiate(enemy, transform);
            timeToSpawn = Time.time + spawnStep;
        }   
    }

}
