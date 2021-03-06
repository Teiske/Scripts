﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    [SerializeField] private GameObject hitEffect;

    //  Checks to see of the bullet has collided with an object
    private void OnCollisionEnter2D(Collision2D collision) {

        //  Creates a hit effect where the bullet collides with an object and 
        //  deletes the bullet and after 5 seconds the hit effet.
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        //  If statement to check if the bullet hit an enemy
        if (collision.gameObject.CompareTag("Enemy")) {
            Destroy(collision.gameObject); // this destroys the enemy
            Destroy(gameObject); // this destroys the bullet
        }

        //  Destroy the bullet after 6 seconds if it hasn't hit
        //  anything yet.
        Destroy(gameObject, 6f);
    }

}
