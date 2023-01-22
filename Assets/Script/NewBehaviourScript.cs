using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    private float pox;
    public float[] xx, yy;
    private static int  f = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Awe()
    {
        pox = GameObject.FindWithTag("Player").transform.position.x;
        poy = GameObject.FindWithTag("Player").transform.position.y;
        xx[k] = posx;
        yy[k] = posy;

        k++;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
