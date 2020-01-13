using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Follow : MonoBehaviour {

    [SerializeField]
    private float speed;
    [SerializeField]
    private float stoppingDistance;
    [SerializeField]
    private float retreatDistance;
    [SerializeField]
    private float stopFollowDistance;
    [SerializeField]
    private float minX;
    [SerializeField]
    private float maxX;
    [SerializeField]
    private float minY;
    [SerializeField]
    private float maxY;

    private float waiTime;
    [SerializeField]
    private float startWaitTime;

    [SerializeField]
    private Transform moveSpot;

    private Transform target;

    //private int randomSpot;

    // Start is called before the first frame update
    void Start() {
        // Find the player object
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        waiTime = startWaitTime;

        moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    // Update is called once per frame
    void Update() {

        if (Vector2.Distance(transform.position, target.position) > stopFollowDistance) {
            transform.position = Vector2.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, moveSpot.position) < 0.2f) {
                if (waiTime <= 0) {
                    moveSpot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                    waiTime = startWaitTime;
                }
                else {
                    waiTime -= Time.deltaTime;
                }
            }
        }
        // Move towards the player. If close enough stop moving.
        else if (Vector2.Distance(transform.position, target.position) < stopFollowDistance) {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        // If the enemy gets to close to the player move away
        else if (Vector2.Distance(transform.position, target.position) < stoppingDistance && Vector2.Distance(transform.position, target.position) > retreatDistance) {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, target.position) < retreatDistance) {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        }
        else {
            //transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
            //if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f) {
            //    if (waiTime <= 0) {
            //        randomSpot = Random.Range(0, moveSpots.Length);
            //        waiTime = startWaitTime;
            //    }
            //    else {
            //        waiTime -= Time.deltaTime;
            //    }
            //}
            //Debug.Log("Enemy moving");
        }
    }
}

