using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rightClickDoor : MonoBehaviour
{

    public Transform player;
    public Transform door;
    
    

   

    public float minDist = 3;
    public float dist;

    public string levelName;

    void Start()
    {
    }

    // Update is called once per frame

    void Update()
    {
        dist = Vector3.Distance(player.position, door.position);
        if (dist < minDist)
        {
            OnMouseOver();
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}