using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public static int c = 0;
    public static int d = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        c++;
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        c--;
        d = c;
        
    }
    
}
