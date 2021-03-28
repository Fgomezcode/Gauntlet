using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openDir;
    //0 -- spawner is inactive.
    //1  -- top left
    //2 -- top middle
    //3 -- top right
    //4 -- middle left
    //5 -- middle middle
    //6 -- middle right
    //7 bottom left
    //8 bottom middle
    //9 bottom right
    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;
   
     void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();

        Invoke("spawn", 0.025f);

        Destroy(gameObject, 0.1f);
    }

    void spawn()
    {
       
        if (spawned == false)
        {
            if (openDir == 1)
            {
               //Spawn room in top left position.
                rand = Random.Range(0, templates.topLeft.Length);
                Instantiate(templates.topLeft[rand], transform.position, templates.topLeft[rand].transform.rotation);

            }
            else if (openDir == 2)
            {
                //spawn room top middle position
                rand = Random.Range(0, templates.topMiddle.Length);
                Instantiate(templates.topMiddle[rand], transform.position, templates.topMiddle[rand].transform.rotation);
            }
            else if (openDir == 3)
            {
                //spawn room in top right position
                rand = Random.Range(0, templates.topRight.Length);
                Instantiate(templates.topRight[rand], transform.position, templates.topRight[rand].transform.rotation);
            }
            else if (openDir == 4)
            {
                //spawn room in middle left position
                rand = Random.Range(0, templates.middleLeft.Length);
                Instantiate(templates.middleLeft[rand], transform.position, templates.middleLeft[rand].transform.rotation);
            }
            else if (openDir == 5)
            {
                //spawn room in middle middle position
                rand = Random.Range(0, templates.middleMiddle.Length);
                Instantiate(templates.middleMiddle[rand], transform.position, templates.middleMiddle[rand].transform.rotation);
            }
            else if (openDir == 6)
            {
                //spawn room in middle right position
                rand = Random.Range(0, templates.middleRight.Length);
                Instantiate(templates.middleRight[rand], transform.position, templates.middleRight[rand].transform.rotation);
            }
            else if (openDir == 7)
            {
                //spawn room in bottom left position
                rand = Random.Range(0, templates.bottomLeft.Length);
                Instantiate(templates.bottomLeft[rand], transform.position, templates.bottomLeft[rand].transform.rotation);
            }
            else if (openDir == 8)
            {
                //spawn room in bottom middle left position
                rand = Random.Range(0, templates.bottomMiddle.Length);
                Instantiate(templates.bottomMiddle[rand], transform.position, templates.bottomMiddle[rand].transform.rotation);
            }
            else if (openDir == 9)
            {
                //spawn room in middle left position
                rand = Random.Range(0, templates.bottomRight.Length);
                Instantiate(templates.bottomRight[rand], transform.position, templates.bottomRight[rand].transform.rotation);
            }

            spawned = true;
        }
        
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("SpawnPoint"))
        {
            if(other.GetComponent<RoomSpawner>().spawned == false && spawned == false)
            {
                //spawn walls
                Instantiate(templates.closedRoom, transform.position, templates.closedRoom.transform.rotation);
                Destroy(gameObject);
            }
            spawned = true;
        }
    }

}
