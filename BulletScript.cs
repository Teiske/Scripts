using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    [SerializeField]
    private GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision) {

        //  Creates a hit effect where the bullet collides with an object and 
        //  deletes the bullet and after 5 seconds the hot effet.
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        // Need an if statement here.
        Destroy(gameObject);
    }
}
