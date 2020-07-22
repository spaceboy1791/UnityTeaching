using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstClass : MonoBehaviour
{
    public static FirstClass instance;

    public static string name;
    private void Awake()
    {
        instance = this;
    }

    public event Action onCoinCollection;
    public void OnTriggerCoin()
    {
        if(onCoinCollection!=null)
        {
            onCoinCollection();
        }

        
    }



    /// Singleton 
    /// Observer 
}
