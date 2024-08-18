using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button1 : MonoBehaviour
{
    public int behav =0;
    public Image[] img;
    public static int btnclick=0;
 
    public int plyr=1;
    public Button btn;
    //private Button btn;
    void Start()
    {
        btn = GetComponent<Button>();
        img = GetComponentsInChildren<Image>();
        btn.onClick.AddListener(clicked23);
        //btn = GetComponent<Button>();
    }


    void Update()
    {

        if (behav == 2)
        {
            img[2].enabled = true;
        }
        if (btnclick % 2 == 0)
        {
            plyr = 1;
        }
        else
        {
            plyr = 2;
        }
        //img[1].enabled = true;
    }
    public void clicked()
    {
        behav = 1;
        img[1].enabled = true;
        this.GetComponent<Button>().interactable = false;
        btnclick++;
        print(btnclick);
       
    }
    public void clicked23()
    {
        btnclick++;
        if (btnclick%2 == 0)
        {
            behav = 1;
            img[1].enabled = true;
            this.GetComponent<Button>().interactable = false;
           
        }
        else
        {
            behav = 2;
            img[2].enabled = true;
            this.GetComponent<Button>().interactable = false;

        }
        
        
       

    }
}
