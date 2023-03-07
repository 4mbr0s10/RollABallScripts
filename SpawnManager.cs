
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public int enemyIndex;
    public float enemySpawnX;
    public float enemySpawnZ;
    
    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            enemyIndex = Random.Range(0, enemies.Length);
            enemySpawnX = 780;
            enemySpawnZ = 800;

            Vector3 spawnPos = new Vector3(enemySpawnX, 71, enemySpawnZ);
            Instantiate(enemies[enemyIndex], spawnPos, enemies[enemyIndex].transform.rotation);
        }
    }
}
//X 760 802 Z 790 829