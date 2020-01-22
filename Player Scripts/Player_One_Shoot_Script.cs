using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_One_Shoot_Script : MonoBehaviour {

    [SerializeField] private float bulletForce = 20f;

    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bulletPrefab;

    //  Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    //  Shoot is called when the Fire1 button is pressed
    //  which is either Mouse Button 0 or Joystick Button 0.
    private void Shoot() {
        //  Creates a bullet at the fire point current position and rotation.
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        //  Calles to the Rigibody2D component on the bullet.
        Rigidbody2D rb2D = bullet.GetComponent<Rigidbody2D>();

        // Adds a force to the bullet when it is created.
        // Forcemode.Impulse adds the force immidiatly to the bullet.
        rb2D.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
