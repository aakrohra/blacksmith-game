using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closePanel : MonoBehaviour
{

    public GameObject panel;

    public void panelClose() {
        panel.SetActive(false);
    }


   
}
