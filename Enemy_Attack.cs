using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour {

    [SerializeField] private float damage;
    [SerializeField] private Health_System health_System;

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag("Player")) {
            Damage();
            Debug.Log("Collision");
        }
    }

    void Damage() {
        health_System.Health -= damage;
        health_System.UpdateHealth();
    }
}
