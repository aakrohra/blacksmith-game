using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closePanel : MonoBehaviour
{

    public GameObject panel;

    public void panelClose() {
      if (panel.active != false) {
        panel.SetActive(false);
      }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
