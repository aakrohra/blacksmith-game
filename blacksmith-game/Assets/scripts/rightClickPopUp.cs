using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightClickPopUp : MonoBehaviour
{

    public GameObject panel;
    public Transform player;

    public float minDist = 3;
    public float dist;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame

    void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);
    }

    void OnMouseOver() {
        if(dist < minDist) {
            if (Input.GetMouseButtonDown(1)) {
                panel.SetActive(true);
            }
        }
    }
}
