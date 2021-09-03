using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class rightClickAnvil : MonoBehaviour
{

    public bool canUseAnvil = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        canUseAnvil = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        canUseAnvil = false;
    }



}
