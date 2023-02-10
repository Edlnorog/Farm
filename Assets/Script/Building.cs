
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Building : MonoBehaviour
{
    public GameObject buildingToPlace;
    private float posx, posy;
    public float[] xm = new float[100], ym = new float[100];
    private static int f = 0, k = 0;
    private static float okr, okri;
    public GameObject closest;
    public GameObject[] gg;
    public string nearest;
    public Vector3 fff, yu, ui;
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
        //GameObject.FindWithTag("Finish").transform.parent = GameObject.FindWithTag("Respawn").transform;
        //nearest= Findclothestenemy().name;
        //yu = Findclothestenemy().transform.position;
        //Debug.Log(nearest);
        //nearest = null;

        
        if (Run.px < 0)
        {
            if (Triggers.c <7)
            {

            
            Instantiate(buildingToPlace, new Vector3(posx - 0.5f, posy, 0), Quaternion.identity).transform.parent = GameObject.FindWithTag("Respawn").transform; ;
            }

        }

        if (Run.px > 0)
        {


        }
        Debug.Log(gg);
        k++;
        f = 0;
    }
    /*
    GameObject Findclothestenemy()
    {
        float distance = Mathf.Infinity;
        float distance2 = Mathf.Infinity;
        Vector3 position = GameObject.FindWithTag("Pot").transform.position;
        foreach (GameObject go in gg)
        {
            Vector3 diff = go.transform.position - position;
     
            float curDistance = diff.sqrMagnitude;
            if (curDistance<distance)
            {
                closest = go;
                distance= curDistance;
                fff = closest.transform.position;
            }
            if (curDistance< distance & distance>distance2) 
            { 
                distance2 = curDistance;
                closest = go;
            }
        }
        //fff = new closest.transform.position;
        return closest;            
    }
    */
}    
    
