
using UnityEngine.UI;
using System.Collections;

using UnityEngine;
using UnityEngine.UI;
using System;
using Unity.Mathematics;
using Random = UnityEngine.Random;
using UnityEditor;
using System.Drawing;
using UnityEngine.SceneManagement;
using System.Threading;
using UnityEngine.U2D.Animation;
using UnityEditor.PackageManager;



public class NewBehaviourScript : MonoBehaviour
{ 
    public Building buildingToPlace;
    private float posx,posy;
    
    //GameObject.FindWithTag("Player").tarnsorm.position 
    public void build()
    {
        posx = GameObject.FindWithTag("Player").transform.position.x;
        posy = GameObject.FindWithTag("Player").transform.position.y;
        Instantiate(buildingToPlace, new Vector3(posx, posy, 0), Quaternion.identity);
    } 
    
}
