
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    public GameObject buildingToPlace;
    private float posx, posy;

    //GameObject.FindWithTag("Player").tarnsorm.position 
    public void build()
    {
        posx = GameObject.FindWithTag("Player").transform.position.x;
        posy = GameObject.FindWithTag("Player").transform.position.y;
        Instantiate(buildingToPlace, new Vector3(posx, posy, 0), Quaternion.identity);

        int x = Mathf.RoundToInt(GameObject.FindWithTag("Player").transform.position.x);
        int y = Mathf.RoundToInt(GameObject.FindWithTag("Player").transform.position.y);




    }
}