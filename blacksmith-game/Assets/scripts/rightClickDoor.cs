using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class rightClickDoor : MonoBehaviour
{

    public bool canUseDoor = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        canUseDoor = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        canUseDoor = false;
    }

  

}