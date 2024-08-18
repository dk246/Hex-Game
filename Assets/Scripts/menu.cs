using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject missionpnl;
    public GameObject modepnl;
    public int mission = 0;
    public int plyr = 0;
    public Text plyer;
    public int temp1;
    public int temp2;
   


    void Start()
    {
       
        missionpnl.SetActive(false);
        modepnl.SetActive(false);
        

    }
    void Update()
    {
        temp1 = button1.btnclick;
        temp2 = button.btnclick;
        

        if((temp2 % 2) == 0)
        {
            
            plyr = 1;
        }
   
        else if ((temp2 % 2 ) == 1)
        {
            
            plyr = 2;
        }

       // plyer.text = "Player " + plyr;
    }
    public void Menu()
    {
        missionpnl.SetActive(true);
    }
    public void mode()
    {
        missionpnl.SetActive(false);
        modepnl.SetActive(true);
    }
    public void Close()
    {
        missionpnl.SetActive(false);
        modepnl.SetActive(false);
        mission = 0;
    }

    public void m1()
    {
        mission = 1;
        missionpnl.SetActive(false);
        modepnl.SetActive(true);
    }
    public void m2()
    {
        mission = 2;
        missionpnl.SetActive(false);
        modepnl.SetActive(true);
    }
    public void m3()
    {
        mission = 3;
        missionpnl.SetActive(false);
        modepnl.SetActive(true);
    }

    public void plyr1()
    {
        if (mission == 1)
        {
            SceneManager.LoadScene(0);
        }
        else if (mission == 2)
        {
            SceneManager.LoadScene(2);
        }
        else if (mission == 3)
        {
            SceneManager.LoadScene(4);
        }
    }
    public void plyr2()
    {
        if (mission == 1)
        {
            SceneManager.LoadScene(1);
        }
        else if (mission == 2)
        {
            SceneManager.LoadScene(3);
        }
        else if (mission == 3)
        {
            SceneManager.LoadScene(5);
        }
    }
}
