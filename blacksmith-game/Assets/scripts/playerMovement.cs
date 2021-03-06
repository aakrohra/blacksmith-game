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

  public GameObject[] panels;

  void Start () {
    body = GetComponent<Rigidbody2D>();
    renderer = GetComponent<SpriteRenderer>();

    // panels = GameObject.FindGameObjectsWithTag("UIPanel");
    // for (int i = 0; i < panels.Length; i++) {
    //   panels[i].SetActive(false);
    // }

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

    // REMOVE WHEN BUILDING EXE
    panels = GameObject.FindGameObjectsWithTag("UIPanel");

    for (int i = 0; i < panels.Length; i++) {
      if (panels[i].active == true) {
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
