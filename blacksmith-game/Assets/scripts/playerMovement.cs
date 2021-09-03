using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
  Rigidbody2D body;
  SpriteRenderer renderer;

  float horizontal;
  float vertical;
  float moveLimiter = 0.7f;

  public float runSpeed = 20.0f;

  public GameObject[] pc;

  void Start () {
    body = GetComponent<Rigidbody2D>();
    renderer = GetComponent<SpriteRenderer>();

    pc = GameObject.FindGameObjectsWithTag("mainObjects");
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

    for (int i = 0; i < pc.Length; i++) {
      if (pc[i].GetComponent<rightClickPopUp>().panelOn == true) {
        horizontal = 0;
        vertical = 0;
      }
    }
  }

  void FixedUpdate() {
    if (horizontal != 0 && vertical != 0) {
      horizontal *= moveLimiter;
      vertical *= moveLimiter;
    }

    body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
  }
}
