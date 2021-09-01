using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
  Rigidbody2D body;
  SpriteRenderer renderer;

  public GameObject panel;
  public GameObject panel2;

  public GameObject panelcheck;

  float horizontal;
  float vertical;
  float moveLimiter = 0.7f;

  public float runSpeed = 20.0f;

  void Start () {
    body = GetComponent<Rigidbody2D>();
    renderer = GetComponent<SpriteRenderer>();

    // panelcheck = GameObject.FindGameObjectWithTag("mainObjects");
  }

  void Update() {
    horizontal = Input.GetAxisRaw("Horizontal");
    vertical = Input.GetAxisRaw("Vertical");

    if (horizontal > 0) {
      renderer.flipX = false;
    }
    if (horizontal < 0) {
      renderer.flipX = true;
    }
  }

  void FixedUpdate() {

    // if (mainObjects.GetComponent<rightClickPopUp>.panelOn == true) {
    //   horizontal = 0;
    //   vertical = 0;
    // }

    if (horizontal != 0 && vertical != 0) {
      horizontal *= moveLimiter;
      vertical *= moveLimiter;
    }

    body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);

  }
}
