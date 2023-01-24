
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Building : MonoBehaviour
{
    public GameObject buildingToPlace;
    private float posx, posy;
    public float[] xm=new float[100] , ym=new float[100] ;
    private static int f=0;
    private static float okr,okri;
   

    //GameObject.FindWithTag("Player").tarnsorm.position 
    private void Start()
    {
        //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss")); //Выводим только время
        
    }
    public void build()
    {
        posx = GameObject.FindWithTag("Player").transform.position.x;
        posy = GameObject.FindWithTag("Player").transform.position.y;
        
        

        for (int i = 0; i < xm.Length; i++)
        {
            if (Math.Abs(posx - xm[i]) < 0.3f & xm[i]!=0)
            {
                f = 1; 
                break;
            }
        }

        if (Run.px < 0)
        {
            
            if (f != 1)
            {
                for (int i = 0; i < xm.Length; i++)
                {
                    Instantiate(buildingToPlace, new Vector3(posx - 0.3f, posy, 0), Quaternion.identity);
                    if (xm[i] == 0)
                    {
                        
                        xm[i] = posx + 0.3f;
                        ym[i] = posy + 0.3f;
                        break;
                        
                    }
                 
                }
                
            }
        
            
                
        }

        if (Run.px > 0)
        {

            if (f != 1)
            {

                for (int i = 0; i < xm.Length; i++)
                {
                    Instantiate(buildingToPlace, new Vector3(posx + 0.3f, posy, 0), Quaternion.identity);
                    if (xm[i] == 0)
                    {

                        xm[i] = posx - 0.3f;
                        ym[i] = posy - 0.3f;
                        break;

                    }

                }

            }
        }        
        
        
        f = 0;
    }
   
   
}    