using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour
{
    public Button[] all;
    public Button[] clicked;
    void Start()
    {
        all = GetComponentsInChildren<Button>();
        
    }

    
    void Update()
    {
        for (int i =0; i < all.Length; i++)
        {
            
        }
        foreach(Button i in all)
        {
        
            
        }
    }
}
