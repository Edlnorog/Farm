
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Building : MonoBehaviour
{
    public GameObject buildingToPlace;
    private float posx, posy;

    //GameObject.FindWithTag("Player").tarnsorm.position 
    public void build()
    {
        posx = GameObject.FindWithTag("Player").transform.position.x-0.5f;
        posy = GameObject.FindWithTag("Player").transform.position.y;
        Instantiate(buildingToPlace, new Vector3(posx, posy, 0), Quaternion.identity);
        





    }
}    