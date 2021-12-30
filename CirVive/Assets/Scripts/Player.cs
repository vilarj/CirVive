using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jump_force;
    public float movement_speed;
    //private Touch touch;
    // Start is called before the first frame update
    void Start() {
        rb = new Rigidbody2D();
        jump_force = 5f;   
        movement_speed = 0.05f; 
    }

    // Update is called once per frame
    void Update() {
        
    }
    
    void FixedUpdate() {
        TouchMovement();
        // KeyJump();
    }

    void TouchMovement() {
        //touch = Input.GetTouch(0);

        if (Input.GetMouseButton(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (mousePos.x > 1) {
                transform.Translate(movement_speed, 0, 0);
            }

            else if (mousePos.x < -1) {
                transform.Translate(-movement_speed, 0, 0);
            }
        }
    }

    // void KeyJump() {
    //     if (Input.GetKeyDown ("space")){ 
    //         GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump_force), ForceMode2D.Impulse);
    //     }
    // }
}
