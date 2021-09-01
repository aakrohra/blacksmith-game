using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightClickPopUp : MonoBehaviour
{

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame

    void Update()
    {
    }

    void OnMouseOver() {
      if (Input.GetMouseButtonDown(1)) {
          panel.SetActive(true);
      }
    }

}
