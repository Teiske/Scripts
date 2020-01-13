using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour {

    [SerializeField]
    private Transform enemy_Object;
    [SerializeField]
    private int numberOfEnemies;
    [SerializeField]
    private float minX, maxX;
    [SerializeField]
    private float minY, maxY;

    //private Vector3 position = new Vector3(Random.Range(-9f, 9f), Random.Range(-7.5f, 7.5f), 0f);

    // Start is called before the first frame update
    void Start() {
        //Instantiate(enemy_Object, new Vector3(0,0,0), Quaternion.identity);
        SpawnEnemies();
    }

    // Update is called once per frame
    void Update() {
        //for (int i = 0; i < numberOfEnemies; i++) {
        //    Instantiate(enemy_Object, GeneratePosition(), Quaternion.identity);
        //}
    }

    void SpawnEnemies() {
        for (int i = 0; i < numberOfEnemies; i++) {
            Instantiate(enemy_Object, GeneratePosition(), Quaternion.identity);
        }
    }

    Vector3 GeneratePosition() {
        float x, y, z;
        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY);
        z = 0;
        return new Vector3(x, y, z);
    }
}
