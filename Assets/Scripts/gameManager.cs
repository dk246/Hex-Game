using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    public GameObject bg;
    void Start()
    {
        Instantiate(canvas, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(bg, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
