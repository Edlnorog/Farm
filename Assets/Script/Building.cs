
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Building : MonoBehaviour
{
    public GameObject buildingToPlace;
    private float posx, posy;
    public float[] xm=new float[100] , ym=new float[100] ;
    private static int f=0,k=0;
    private static float okr,okri;
    public GameObject[] gg;
    //Instantiate(buildingToPlace, new Vector3(posx - 0.3f, posy, 0), Quaternion.identity);
    //Instantiate(buildingToPlace, new Vector3(posx + 0.3f, posy, 0), Quaternion.identity);
    //GameObject.FindWithTag("Player").tarnsorm.position 
    void Start()
    {
        //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss")); //Выводим только время
        
        
    }
    public void build()
    {
        posx = GameObject.FindWithTag("Player").transform.position.x;
        posy = GameObject.FindWithTag("Player").transform.position.y;
        gg = GameObject.FindGameObjectsWithTag("Finish");


        

        if (Run.px < 0)
        {
            
            
            
                
        }

        if (Run.px > 0)
        {

            
        }
        Debug.Log(gg);
        k = 0;
        f = 0;
    }
    
   
}    