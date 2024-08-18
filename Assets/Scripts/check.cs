using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class check : MonoBehaviour
{
    public GameObject[] all;
    public GameObject[] allred;
    public int[] col1 = new int[6];
    public int[] col2 = new int[6];
    public int[] col3 = new int[6];
    public int[] col4 = new int[6];
    public int[] col5 = new int[6];
    public int[] col6 = new int[6];
   

    public int[] raw1 = new int[6];
    public int[] raw2 = new int[6];
    public int[] raw3 = new int[6];
    public int[] raw4 = new int[6];
    public int[] raw5 = new int[6];
    public int[] raw6 = new int[6];

    //public List<int> lst = new List<int>();
    //public Image[] imgs;
    public GameObject panel;
    public GameObject failPanel;
    public int[] temp = new int[36];
    public int[] temp2 = new int[36];
    public int start = 6;
    
    void Start()
    {
        for (int i =0; i < col1.Length; i++)
        {
            col1[i] = -1;
            raw1[i] = -1;
        }
        print("plz..");
        panel.SetActive(false);
    }
    public void restart()
    {
        button.btnclick = 0;
        SceneManager.LoadScene(0);
    }
    public void BTN()
    {
        if(button.btnclick == 1)
        {
            if(Random.value < 0.5)
            {
                all[14].GetComponent<button>().behav = 2;
                all[14].GetComponent<Button>().interactable = false;
            }
            else
            {
                all[15].GetComponent<button>().behav = 2;
                all[15].GetComponent<Button>().interactable = false;
            }
        }
        else if(button.btnclick == 2)
        {
            if(Random.value < 0.25 && all[13].GetComponent<button>().behav != 2 && all[13].GetComponent<button>().behav != 1)
            {
              
                 all[13].GetComponent<button>().behav = 2;
                 all[13].GetComponent<Button>().interactable = false;
                
            }
            else if (Random.value < 0.5 && all[14].GetComponent<button>().behav != 2 && all[13].GetComponent<button>().behav != 1)
            {
           
                 all[14].GetComponent<button>().behav = 2;
                 all[14].GetComponent<Button>().interactable = false;
                
            }
            else if (Random.value < 0.75 && all[15].GetComponent<button>().behav != 2 && all[13].GetComponent<button>().behav != 1)
            {
               
                 all[15].GetComponent<button>().behav = 2;
                 all[15].GetComponent<Button>().interactable = false;
                
            }
            else 
            {
                if (all[16].GetComponent<button>().behav != 2 && all[13].GetComponent<button>().behav != 1)
                {
                    all[16].GetComponent<button>().behav = 2;
                    all[16].GetComponent<Button>().interactable = false;
                }
            }
        }
        else
        {
            bool tt = true;
            while (tt)
            {
                int x = Random.Range(6, 36);
                if(all[x].GetComponent<button>().behav != 2 && all[x].GetComponent<button>().behav != 1)
                {
                    all[x].GetComponent<button>().behav = 2;
                    all[x].GetComponent<Button>().interactable = false;
                    tt = false;
                    break;
                }
            }
            
           
        }
        
        //imgs[8].enabled = true;
    }
    
    void Update()
    {

 

        foreach (int i in col1)
        {

            if (i != -1)
            {
                foreach (int j in col2)
                {
                    if ( i != 5)
                    {
                        if (j == i + 6)
                        {
                            temp[j] = j;
                            for(int x = 0; x < 6; x++)
                            {
                                foreach(int y in col2)
                                {
                                    if(y == j - x)
                                    {
                                        foreach (int z in col2)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp[y] = y;
                                            }
                                        }                              
                                        continue;
                                    }
  
                                }
                            }
                        }
                        else if (j == i + 7)
                        {

                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col2)
                                {
                                   
                                    if (y == j + x)
                                    {
                                        foreach (int z in col2)
                                        {
                                            if (y - 1 == z)
                                            {
                                                temp[y] = y;
                                            }
                                        }
                                  
                                       
                                        continue;
                                    }
                         
                                }
                            }
                        }
                    }

                    else if (i == 5)
                    {
                        if (j == i + 6)
                        {
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col2)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col2)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp[y] = y;
                                            }
                                        }
                                    
                                        continue;
                                    }
                                    else
                                    {
                                       // break;
                                    }
                                }
                            }
                        }

                    }


                }
            }
        }
        foreach (int i in temp)
        {
            if (i != 0)
            {
                foreach (int j in col3)
                {
                    if ( i != 11)
                    {
                        if (j == i + 6)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col3)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col3)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp[y] = y;
                                            }
                                        }
                                        continue;
                                    }

                                }
                            }
                            
                         
                        }
                        else if (j == i + 7)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col3)
                                {
                                    
                                    if (y == j + x)
                                    {
                                        foreach (int z in col3)
                                        {
                                            if (y - 1 == z)
                                            {
                                                temp[y] = y;
                                            }
                                        }


                                        continue;
                                    }

                                }
                            }
                        }
            
                    }
                    
                    else if (i == 11)
                    {
                        if (j == i + 6)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col3)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col3)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp[y] = y;
                                            }
                                        }

                                        continue;
                                    }
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
               
                    }
                    
                }
            }
        }
        foreach (int i in temp)
        {
            if (i != 0)
            {
                foreach (int j in col4)
                {
                    if (i != 17)
                    {
                        if (j == i + 6)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col4)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col4)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp[y] = y;
                                            }
                                        }
                                        continue;
                                    }

                                }
                            }
                        }
                        else if (j == i + 7)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col4)
                                {
                                    
                                    if (y == j + x)
                                    {
                                        foreach (int z in col4)
                                        {
                                            if (y - 1 == z)
                                            {
                                                temp[y] = y;
                                            }
                                        }


                                        continue;
                                    }

                                }
                            }
                        }
                        
                    }
                    
                    else if (i == 17)
                    {
                        if (j == i + 6)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col4)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col4)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp[y] = y;
                                            }
                                        }

                                        continue;
                                    }
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
                   
                    }
                    
                }
            }
        }
        foreach (int i in temp)
        {
            if (i != 0)
            {
                foreach (int j in col5)
                {
                    if (i != 23)
                    {
                        if (j == i + 6)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col5)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col5)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp[y] = y;
                                            }
                                        }
                                        continue;
                                    }

                                }
                            }
                        }
                        else if (j == i + 7)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col5)
                                {
                                   
                                    if (y == j + x)
                                    {
                                        foreach (int z in col5)
                                        {
                                            if (y - 1 == z)
                                            {
                                                temp[y] = y;
                                            }
                                        }


                                        continue;
                                    }

                                }
                            }
                        }
                       
                    }
                    
                    else if (i == 23)
                    {
                        if (j == i + 6)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col5)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col5)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp[y] = y;
                                            }
                                        }

                                        continue;
                                    }
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
                    
                    }
                   
                }
            }
        }
        foreach (int i in temp)
        {
            if (i != 0)
            {
                foreach (int j in col6)
                {
                    if (i != 29)
                    {
                        if (j == i + 6)
                        {
                            panel.SetActive(true);
                            temp[i] = 0;
                            temp[j] = j;

                        }
                        else if (j == i + 7)
                        {
                            panel.SetActive(true);
                            temp[i] = 0;
                            temp[j] = j;

                        }

                    }

                    else if (i == 29)
                    {
                        if (j == i + 6)
                        {
                            panel.SetActive(true);
                            temp[i] = 0;
                            temp[j] = j;

                        }
                    }
                }
            }
        }

        for (int i = 0; i < all.Length; i++)
        {

            if (all[i].GetComponent<button>().behav == 1)
            {

                if (i < 6)
                {
                    col1[i] = i;
                }
                else if (i < 12)
                {
                    col2[i - 6] = i;
                }
                else if (i < 18)
                {
                    col3[i - 12] = i;
                }
                else if (i < 24)
                {
                    col4[i - 18] = i;
                }
                else if (i < 30)
                {
                    col5[i - 24] = i;
                }
                else
                {

                    col6[i - 30] = i;
                }

            }
        }

        for (int i = 0; i < all.Length; i++)
        {

            if (allred[i].GetComponent<button>().behav == 2)
            {

                if (i < 6)
                {
                    raw1[i] = i;
                }
                else if (i < 12)
                {
                    raw2[i - 6] = i;
                }
                else if (i < 18)
                {
                    raw3[i - 12] = i;
                }
                else if (i < 24)
                {
                    raw4[i - 18] = i;
                }
                else if (i < 30)
                {
                    raw5[i - 24] = i;
                }
                else
                {

                    raw6[i - 30] = i;
                }

            }
        }



        foreach (int i in raw1)
        {

            if (i != -1)
            {
                foreach (int j in raw2)
                {
                    if (i != 5)
                    {
                        if (j == i + 6)
                        {
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw2)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw2)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp2[y] = y;
                                            }
                                        }
                                        continue;
                                    }

                                }
                            }
                        }
                        else if (j == i + 7)
                        {

                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw2)
                                {

                                    if (y == j + x)
                                    {
                                        foreach (int z in raw2)
                                        {
                                            if (y - 1 == z)
                                            {
                                                temp2[y] = y;
                                            }
                                        }


                                        continue;
                                    }

                                }
                            }
                        }
                    }

                    else if (i == 5)
                    {
                        if (j == i + 6)
                        {
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw2)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw2)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp2[y] = y;
                                            }
                                        }

                                        continue;
                                    }
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }

                    }


                }
            }
        }
        foreach (int i in temp2)
        {
            if (i != 0)
            {
                foreach (int j in raw3)
                {
                    if (i != 11)
                    {
                        if (j == i + 6)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw3)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw3)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp2[y] = y;
                                            }
                                        }
                                        continue;
                                    }

                                }
                            }


                        }
                        else if (j == i + 7)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw3)
                                {

                                    if (y == j + x)
                                    {
                                        foreach (int z in raw3)
                                        {
                                            if (y - 1 == z)
                                            {
                                                temp2[y] = y;
                                            }
                                        }


                                        continue;
                                    }

                                }
                            }
                        }

                    }

                    else if (i == 11)
                    {
                        if (j == i + 6)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw3)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw3)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp2[y] = y;
                                            }
                                        }

                                        continue;
                                    }
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }

                    }

                }
            }
        }
        foreach (int i in temp2)
        {
            if (i != 0)
            {
                foreach (int j in raw4)
                {
                    if (i != 17)
                    {
                        if (j == i + 6)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw4)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw4)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp2[y] = y;
                                            }
                                        }
                                        continue;
                                    }

                                }
                            }
                        }
                        else if (j == i + 7)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw4)
                                {

                                    if (y == j + x)
                                    {
                                        foreach (int z in raw4)
                                        {
                                            if (y - 1 == z)
                                            {
                                                temp2[y] = y;
                                            }
                                        }


                                        continue;
                                    }

                                }
                            }
                        }

                    }

                    else if (i == 17)
                    {
                        if (j == i + 6)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw4)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw4)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp2[y] = y;
                                            }
                                        }

                                        continue;
                                    }
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }

                    }

                }
            }
        }
        foreach (int i in temp2)
        {
            if (i != 0)
            {
                foreach (int j in raw5)
                {
                    if (i != 23)
                    {
                        if (j == i + 6)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw5)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw5)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp2[y] = y;
                                            }
                                        }
                                        continue;
                                    }

                                }
                            }
                        }
                        else if (j == i + 7)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw5)
                                {

                                    if (y == j + x)
                                    {
                                        foreach (int z in raw5)
                                        {
                                            if (y - 1 == z)
                                            {
                                                temp2[y] = y;
                                            }
                                        }


                                        continue;
                                    }

                                }
                            }
                        }

                    }

                    else if (i == 23)
                    {
                        if (j == i + 6)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw5)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw5)
                                        {
                                            if (y + 1 == z)
                                            {
                                                temp2[y] = y;
                                            }
                                        }

                                        continue;
                                    }
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }

                    }

                }
            }
        }
        foreach (int i in temp2)
        {
            if (i != 0)
            {
                foreach (int j in raw6)
                {
                    if (i != 29)
                    {
                        if (j == i + 6)
                        {
                            failPanel.SetActive(true);
                            temp2[i] = 0;
                            temp2[j] = j;

                        }
                        else if (j == i + 7)
                        {
                            failPanel.SetActive(true);
                            temp2[i] = 0;
                            temp2[j] = j;

                        }

                    }

                    else if (i == 29)
                    {
                        if (j == i + 6)
                        {
                            failPanel.SetActive(true);
                            temp2[i] = 0;
                            temp2[j] = j;

                        }
                    }
                }
            }
        }
    }
}
