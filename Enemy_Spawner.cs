using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour {

    [SerializeField] private Transform enemy_Object;
    [SerializeField] private int numberOfEnemies;
    [SerializeField] private int maxNumberEnemies;
    [SerializeField] private float minX, maxX;
    [SerializeField] private float minY, maxY;

    [SerializeField] private bool canSpawnEnemies;

    // Start is called before the first frame update
    void Start() {
        // Calls SpawnEnemies() every 1.5 seconds
        InvokeRepeating("SpawnEnemies", 0f, 1.5f);
    }

    // Update is called once per frame
    void Update() {

    }

    // Spawn enemies on a random position on the screen
    void SpawnEnemies() {
        if (numberOfEnemies < maxNumberEnemies) {
            Instantiate(enemy_Object, GeneratePosition(), Quaternion.identity);
            numberOfEnemies++;
        }
    }

    // Generate a random positon on the screen
    Vector3 GeneratePosition() {
        float x, y, z;
        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY);
        z = 0;
        return new Vector3(x, y, z);
    }
}
