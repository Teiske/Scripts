using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour {

    [SerializeField] private float attackDistance;
    [SerializeField] private float attackDamage;
    [SerializeField] private Health_System health_System;

    private bool playerInRange;

    private Transform player;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update() {
        if (Vector3.Distance(transform.position, player.position) <= attackDistance) {
            Damage();
            playerInRange = true;
        }
        else {
            playerInRange = false;
        }
    }

    private void Damage() {
        health_System.Health -= attackDamage;
        health_System.UpdateHealth();
    }
}
