using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour {

    [SerializeField] private Health_System health_System;

    [SerializeField] private float attackDistance;
    [SerializeField] private float attackDamage;

    [SerializeField] private float hitTime;
    [SerializeField] private float currentTime = 0;

    private bool playerInRange;

    private Transform player;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update() {
        if (Vector3.Distance(transform.position, player.position) <= attackDistance) {
            playerInRange = true;
            if (playerInRange == true) {
                currentTime += Time.deltaTime;
                if (currentTime >= hitTime) {
                    Damage();
                }
            }
        }
        else {
            playerInRange = false;
        }


    }

    private void Damage() {
        health_System.Health -= attackDamage;
        health_System.UpdateHealth();

        currentTime = 0;
    }
}
