using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Follow : MonoBehaviour {

    // Input floats
    [SerializeField] private float speed;
    [SerializeField] private float stoppingDistance;
    [SerializeField] private float retreatDistance;
    [SerializeField] private float stopFollowDistance;


    // Window floats
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    // Time floats
                     private float waiTime;
    [SerializeField] private float startWaitTime;

    // Transforms
    [SerializeField] private Transform moveSpot;
                     private Transform target;

    // Start is called before the first frame update
    void Start() {
        // Find the player object
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        // Set the wait time for each position the enemy reaches
        waiTime = startWaitTime;

        moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    // Update is called once per frame
    void Update() {

        // Move towards the player. If close enough stop moving.
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance) {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}

