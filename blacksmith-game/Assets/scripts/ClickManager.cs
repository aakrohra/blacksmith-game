using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickManager : MonoBehaviour
{

    public string levelName = "";
    public bool clickedOnDoor = false;
    public bool clickedOnAnvil = false;
    public bool clickedOnFurnace = false;
    public bool anvilPanelOn = false;
    public bool furnacePanelOn = false;
    public int dist;
    public Transform player;

    public GameObject anvilPanel;
    public GameObject furnacePanel;

    public GameObject[] pc;


    void Start()
    {
        pc = GameObject.FindGameObjectsWithTag("mainObjects");

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right Click");
            //clicks are represented by pixel space (starts in bottom left) and not world space

            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //when left click, the opint that the mouse is at is saved in 3D
            //can mousePosition be a vector2?

            Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);//converts 3d point to 2d point

            RaycastHit2D hit = Physics2D.Raycast(mousePosition2D, Vector2.zero); //calculates if mouse position is directly on a game object on click
                                                                                 //from mouse position, directly backwards
            if (hit.collider != null) //if you didnt hit empty space
            {
                Debug.Log(hit.collider.gameObject.name);

                switch (hit.collider.gameObject.name)
                {
                    case "actual door":
                        levelName = "TestingHome";
                        clickedOnDoor = true;
                        break;
                    case "door":
                        levelName = "StartingArea";
                        clickedOnDoor = true;
                        break;
                    case "actual anvil":
                        clickedOnAnvil = true;
                        break;
                    case "actual furnace":
                        clickedOnFurnace = true;
                        break;
                    default:
                        clickedOnDoor = false;
                        clickedOnAnvil = false;
                        break;
                }

                if (clickedOnDoor)
                {
                    //dist = Vector3.Distance(player.position, thing.position);
                    for (int i = 0; i < pc.Length; i++)
                    {
                        try {
                          if (pc[i].GetComponent<rightClickDoor>().canUseDoor)
                          {
                            SceneManager.LoadScene(levelName);
                          }
                        } catch {}
                    }

                }

                if (clickedOnAnvil) {
                    for (int i = 0; i < pc.Length; i++) {
                        try {
                            if (pc[i].GetComponent<rightClickAnvil>().canUseAnvil) {
                                anvilPanel.SetActive(true);
                                anvilPanelOn = true;
                            } else {
                                anvilPanelOn = false;
                            }
                        } catch {}
                    }
                }

                if (clickedOnFurnace) {
                    for (int i = 0; i < pc.Length; i++) {
                        try {
                            if (pc[i].GetComponent<rightClickFurnace>().canUseFurnace) {
                                furnacePanel.SetActive(true);
                                furnacePanelOn = true;
                            } else {
                                furnacePanelOn = false;
                            }
                        } catch {}
                    }
                }


                //do another switch for if door, load scene(levelName)

                //if (hit.collider.gameObject.name = "actual door")
                //{
                //    rightClickDoor();
                //}

                //would give us the name of the hit gameobject, then add a force to its rigidbody
                //Debug.Log(hit.collider.gameObject.name);
                //hit.ccollider.attachedRigidbody.AddForcce(Vector2.up);
            }

        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Click");

        }
    }


}
