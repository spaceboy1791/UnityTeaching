using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincolletion : MonoBehaviour
{
   
    public int score = 0;

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="coins")
        {
            //FirstClass.name = "sjdfksdf";
          
            FirstClass.instance.OnTriggerCoin();
           // score += 1;
            Destroy(other.gameObject);
        }
    }
}




//unityspaceboy@gmail.com