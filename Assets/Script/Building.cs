
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Building : MonoBehaviour
{
    public GameObject buildingToPlace;
    private float posx, posy;
    public float[] xm=new float[10] , ym=new float[10] ;
    private static int k=0,f=0;

    //GameObject.FindWithTag("Player").tarnsorm.position 
    private void Start()
    {
        //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss")); //Выводим только время
    }
    public void build()
    {
        posx = GameObject.FindWithTag("Player").transform.position.x;
        posy = GameObject.FindWithTag("Player").transform.position.y;
        
        
        
        
        
        if (Run.px < 0)
        {
            Instantiate(buildingToPlace, new Vector3(posx - 0.3f, posy, 0), Quaternion.identity);
            xm[k] = posx-0.3f;
                
                
        }
        if (Run.px > 0)
        {
            Instantiate(buildingToPlace, new Vector3(posx + 0.3f, posy, 0), Quaternion.identity);
            xm[k] = posx - 0.3f;
        }
                
       k++;

    }
}    