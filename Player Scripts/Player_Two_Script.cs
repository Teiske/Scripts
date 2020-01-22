using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Two_Script : MonoBehaviour {

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private Camera cam;

    Vector2 movement;
    Vector2 aimPosition;

    //  Update is called once per frame.
    void Update() {
        //  Assign horizontal input to the X-axis.
        movement.x = Input.GetAxisRaw("Horizontal2");

        //  Assing vertical input to the Y-axis.
        movement.y = Input.GetAxisRaw("Vertical2");

        // Current mouse position in pixel coordinates
        // converted to world units.
        aimPosition = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    //  FixedUpate is called a fixed amount of time
    //  not relying on the current frame rate.
    void FixedUpdate() {
        //  Moves the character in the direction 
        //  the player pushes the joystick on the controller.
        rb2D.MovePosition(rb2D.position + movement * moveSpeed * Time.fixedDeltaTime);

        //  Checking the aim position from where 
        //  the player is currently standing.
        Vector2 lookDirection = aimPosition - rb2D.position;

        //  Calculate the look angle for the player character.
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;

        //  Apply rotation to the player
        rb2D.rotation = angle;

    }
}
