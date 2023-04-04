using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class RandomEnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Enemies;
    private int NumberOfEnemies;
    private int ChanceOfSpawn;
    public Transform SpawnLocation;
    private bool SpawnerCleanup;


    void Start ()
    {
        ChanceOfSpawn = Random.Range(1, 20);
        foreach (GameObject Element in Enemies)
        {
            NumberOfEnemies++;
        }

        int EnemySelector = Random.Range(0,NumberOfEnemies);

        if (ChanceOfSpawn <= 5){
            Instantiate(Enemies[EnemySelector], SpawnLocation);
            SpawnerCleanup = true;
        }

        if(SpawnerCleanup == false)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
