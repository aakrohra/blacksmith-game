using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightClickPopUp : MonoBehaviour
{

    public GameObject panel;
    public Transform player;

    public float minDist = 3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame

    void Update()
    {

    }

    void OnMouseOver() {
        float dist = Vector3.Distance(player.position, transform.position);
        if(dist < minDist) {
            if (Input.GetMouseButtonDown(1)) {
                panel.SetActive(true);
            }
        }
    }
}
