using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickManager : MonoBehaviour
{
    public string levelName = "";
    public bool clickedOnDoor = false;
    public int dist;
    public Transform player;

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
                    default:
                        clickedOnDoor = false;
                        break;
                }

                if (clickedOnDoor)
                {
                    //dist = Vector3.Distance(player.position, thing.position);
                    if (dist < 1.1)
                    {
                        SceneManager.LoadScene(levelName);
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
