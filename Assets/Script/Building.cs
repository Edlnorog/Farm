
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
    public GameObject closest,a;
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
        //gg = GameObject.FindGameObjectsWithTag("Pot");
        gg = GameObject.FindGameObjectsWithTag("Pot");
        //GameObject.FindWithTag("Finish").transform.parent = GameObject.FindWithTag("Respawn").transform;
        //nearest = Findclothestenemy().name;
        yu = Findclothestenemy().transform.position;
        Debug.Log(yu);
        nearest = null;

        
        if (Run.px < 0)
        {
            

            if ((Math.Abs(yu.x - posx) > 0.65f)||(Math.Abs(yu.y-posy)>0.5f))
            {
                a = Instantiate(buildingToPlace, new Vector3(posx - 0.3f, posy, 0), Quaternion.identity);
                a.transform.parent = GameObject.FindWithTag("Respawn").transform;
                a.transform.localScale = new Vector3(1, 1, 1);
            }
            //Instantiate(buildingToPlace, new Vector3(posx - 0.5f, posy, 0), Quaternion.identity).transform.parent = GameObject.FindWithTag("Respawn").transform;
            //Instantiate(buildingToPlace, new Vector3(posx - 0.5f, posy, 0), Quaternion.identity).transform.localScale=new Vector3(1,1,1);
            
        }

        if (Run.px > 0)
        {
            if ((Math.Abs(yu.x - posx) > 0.65f) || (Math.Abs(yu.y - posy) > 0.5f))
            {
                a = Instantiate(buildingToPlace, new Vector3(posx + 0.3f, posy, 0), Quaternion.identity);
                a.transform.parent = GameObject.FindWithTag("Respawn").transform;
                a.transform.localScale = new Vector3(1, 1, 1);
            }

        }
        Debug.Log(gg);
        k++;
        f = 0;
    }
    
    GameObject Findclothestenemy()
    {
        float distance = Mathf.Infinity;
        //Vector3 position = GameObject.FindWithTag("Player").transform.position;
        Vector3 position = new Vector3(posx, posy, 0);
        foreach (GameObject go in gg)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance<distance)
            {
                closest = go;
                distance= curDistance;
                //fff = closest.transform.position;
            }
            
        }
        //fff = new closest.transform.position;
        return closest;            
    }
    
}    
    
