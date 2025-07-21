using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{

   
    public void OnMouseDown()
    {   
        if(!GameControl.youwin)
        {
            transform.Rotate(0, 0, 90f);
            
        }
    }
}
