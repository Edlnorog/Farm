using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotINVENTORY : MonoBehaviour
{
    public int Time=0;
    public GameObject abc;
    public void ButtonClick()
    {
        GameObject.FindWithTag("PotInventory").SetActive(true);

    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
