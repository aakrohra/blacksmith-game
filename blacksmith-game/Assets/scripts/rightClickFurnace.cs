using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class rightClickFurnace : MonoBehaviour
{

    public bool canUseFurnace = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        canUseFurnace = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        canUseFurnace = false;
    }



}
