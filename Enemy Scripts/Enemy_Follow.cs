using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Follow : MonoBehaviour {

    //  Input floats
    [SerializeField] private float speed;
    [SerializeField] private float stoppingDistance;

    //  Time floats
    [SerializeField] private float startWaitTime;

    private Transform target;

    //  Start is called before the first frame update
    void Start() {
        //  Find the player object
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    //  Update is called once per frame
    void Update() {

        //  Move towards the player. If close enough stop moving.
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance) {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}

