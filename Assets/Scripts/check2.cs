using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class check2 : MonoBehaviour
{
    public GameObject[] all;
    public GameObject[] allred;
    public int[] col1 = new int[11];
    public int[] col2 = new int[11];
    public int[] col3 = new int[11];
    public int[] col4 = new int[11];
    public int[] col5 = new int[11];
    public int[] col6 = new int[11];
    public int[] col7 = new int[11];
    public int[] col8 = new int[11];
    public int[] col9 = new int[11];
    public int[] col10 = new int[11];
    public int[] col11 = new int[11];

    public int[] raw1 = new int[11];
    public int[] raw2 = new int[11];
    public int[] raw3 = new int[11];
    public int[] raw4 = new int[11];
    public int[] raw5 = new int[11];
    public int[] raw6 = new int[11];
    public int[] raw7 = new int[11];
    public int[] raw8 = new int[11];
    public int[] raw9 = new int[11];
    public int[] raw10 = new int[11];
    public int[] raw11 = new int[11];
    //public Image[] imgs;
    public GameObject panel;
    public GameObject failPanel;
    public int[] temp = new int[121];
    public int[] temp2 = new int[121];
    void Start()
    {
        for (int i = 0; i < col1.Length; i++)
        {
            col1[i] = -1;
            raw1[i] = -1;
        }
        panel.SetActive(false);
        failPanel.SetActive(false);
    }
    public void restart()
    {
        button.btnclick = 0;
        SceneManager.LoadScene(2);
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
                int x = Random.Range(6, 121);
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
        
 
        foreach(int i in col1)
        {
            if (i != -1)
            {
                foreach (int j in col2)
                {
                    if( i != 10)
                    {
                        if (j == i + 11)
                        {
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
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

                                }
                            }
                        }
                        else if (j == i + 12)
                        {
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
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
                   
                    else if(i == 10)
                    {
                        if (j == i + 11)
                        {
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
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
        foreach(int i in temp) 
        {
            if (i != 0)
            {
                foreach (int j in col3)
                {
                    if ( i != 21)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
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
                        else if (j == i + 12)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
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
   
                    else if (i == 21)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
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
                    if ( i != 32)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
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
                        else if (j == i + 12)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
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
                    
                    else if (i == 32)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
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
                    if (i != 43)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
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
                        else if (j == i + 12)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
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
                    
                    else if (i == 43)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
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
                    if (i != 54)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col6)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col6)
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
                        else if (j == i + 12)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col6)
                                {
                                   
                                    if (y == j + x)
                                    {
                                        foreach (int z in col6)
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
                    
                    else if (i == 54)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col6)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col6)
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
                  
                    }
                   
                }
            }
        }

        foreach (int i in temp)
        {
            if (i != 0)
            {
                foreach (int j in col7)
                {
                    if ( i != 65)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col7)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col7)
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
                        else if (j == i + 12)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col7)
                                {
                                   
                                    if (y == j + x)
                                    {
                                        foreach (int z in col7)
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
                    
                    else if (i == 65)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col7)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col7)
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
                  
                    }
                    
                }
            }
        }

        foreach (int i in temp)
        {
            if (i != 0)
            {
                foreach (int j in col8)
                {
                    if (i != 76)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col8)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col8)
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
                        else if (j == i + 12)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col8)
                                {
                                   
                                    if (y == j + x)
                                    {
                                        foreach (int z in col8)
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
                   
                    else if (i == 76)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col8)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col8)
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
                      
                    }
                   
                }
            }
        }

        foreach (int i in temp)
        {
            if (i != 0)
            {
                foreach (int j in col9)
                {
                    if (i != 87)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col9)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col9)
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
                        else if (j == i + 12)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col9)
                                {
                                   
                                    if (y == j + x)
                                    {
                                        foreach (int z in col9)
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
   
                    else if (i == 87)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col9)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col9)
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
                   
                    }
              
                }
            }
        }

        foreach (int i in temp)
        {
            if (i != 0)
            {
                foreach (int j in col10)
                {
                    if (i != 98)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col10)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col10)
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
                        else if (j == i + 12)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col10)
                                {
                                  
                                    if (y == j + x)
                                    {
                                        foreach (int z in col10)
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
                    
                    else if (i == 98)
                    {
                        if (j == i + 11)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 11; x++)
                            {
                                foreach (int y in col10)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col10)
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
                     
                    }
                   
                }
            }
        }

        foreach (int i in temp)
        {
            if (i != 0)
            {
                foreach (int j in col11)
                {
                    if (i != 109)
                    {
                        if (j == i + 11)
                        {
                            panel.SetActive(true);
                            temp[i] = 0;
                            temp[j] = j;
                        }
                        else if (j == i + 12)
                        {
                            panel.SetActive(true);
                            temp[i] = 0;
                            temp[j] = j;
                        }
      
                    }
                   
                    else if (i == 109)
                    {
                        if (j == i + 11)
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
            
            if(all[i].GetComponent<button>().behav == 1)
            {
                
                if (i < 11)
                {
                    col1[i] = i ;
                }
                else if (i < 22)
                {
                    col2[i-11] = i ;
                }
                else if (i < 33)
                {
                    col3[i-22] = i;
                }
                else if (i < 44)
                {
                    col4[i-33] = i;
                }
                else if (i < 55)
                {
                    col5[i-44] = i;
                }
                else if (i < 66)
                {
                    col6[i - 55] = i;
                }
                else if (i < 77)
                {
                    col7[i - 66] = i;
                }
                else if (i < 88)
                {
                    col8[i - 77] = i;
                }
                else if (i < 99)
                {
                    col9[i - 88] = i;
                }
                else if (i < 110)
                {
                    col10[i - 99] = i;
                }
                else
                {
                  
                    col11[i-110] = i;
                }

            }
        }
        for (int i = 0; i < all.Length; i++)
        {

            if (allred[i].GetComponent<button1>().behav == 2)
            {

                if (i < 11)
                {
                    raw1[i] = i;
                }
                else if (i < 22)
                {
                    raw2[i - 11] = i;
                }
                else if (i < 33)
                {
                    raw3[i - 22] = i;
                }
                else if (i < 44)
                {
                    raw4[i - 33] = i;
                }
                else if (i < 55)
                {
                    raw5[i - 44] = i;
                }
                else if (i < 66)
                {
                    raw6[i - 55] = i;
                }
                else if (i < 77)
                {
                    raw7[i - 66] = i;
                }
                else if (i < 88)
                {
                    raw8[i - 77] = i;
                }
                else if (i < 99)
                {
                    raw9[i - 88] = i;
                }
                else if (i < 110)
                {
                    raw10[i - 99] = i;
                }
                else
                {

                    raw11[i - 110] = i;
                }

            }
        }




        foreach (int i in raw1)
        {
            if (i != -1)
            {
                foreach (int j in raw2)
                {
                    if (i != 10)
                    {
                        if (j == i + 11)
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
                        else if (j == i + 12)
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

                    else if (i == 10)
                    {
                        if (j == i + 11)
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
                    if (i != 21)
                    {
                        if (j == i + 11)
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
                        else if (j == i + 12)
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

                    else if (i == 21)
                    {
                        if (j == i + 11)
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
                    if (i != 32)
                    {
                        if (j == i + 11)
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
                        else if (j == i + 12)
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

                    else if (i == 32)
                    {
                        if (j == i + 11)
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
                    if (i != 43)
                    {
                        if (j == i + 11)
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
                        else if (j == i + 12)
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

                    else if (i == 43)
                    {
                        if (j == i + 11)
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
                    if (i != 54)
                    {
                        if (j == i + 11)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw6)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw6)
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
                        else if (j == i + 12)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw6)
                                {

                                    if (y == j + x)
                                    {
                                        foreach (int z in raw6)
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

                    else if (i == 54)
                    {
                        if (j == i + 11)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw6)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw6)
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

                    }

                }
            }
        }

        foreach (int i in temp2)
        {
            if (i != 0)
            {
                foreach (int j in raw7)
                {
                    if (i != 65)
                    {
                        if (j == i + 11)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw7)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw7)
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
                        else if (j == i + 12)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw7)
                                {

                                    if (y == j + x)
                                    {
                                        foreach (int z in raw7)
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

                    else if (i == 65)
                    {
                        if (j == i + 11)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw7)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw7)
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

                    }

                }
            }
        }

        foreach (int i in temp2)
        {
            if (i != 0)
            {
                foreach (int j in raw8)
                {
                    if (i != 76)
                    {
                        if (j == i + 11)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw8)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw8)
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
                        else if (j == i + 12)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw8)
                                {

                                    if (y == j + x)
                                    {
                                        foreach (int z in raw8)
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

                    else if (i == 76)
                    {
                        if (j == i + 11)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw8)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw8)
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

                    }

                }
            }
        }

        foreach (int i in temp2)
        {
            if (i != 0)
            {
                foreach (int j in raw9)
                {
                    if (i != 87)
                    {
                        if (j == i + 11)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw9)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw9)
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
                        else if (j == i + 12)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw9)
                                {

                                    if (y == j + x)
                                    {
                                        foreach (int z in raw9)
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

                    else if (i == 87)
                    {
                        if (j == i + 11)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw9)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw9)
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

                    }

                }
            }
        }

        foreach (int i in temp2)
        {
            if (i != 0)
            {
                foreach (int j in raw10)
                {
                    if (i != 98)
                    {
                        if (j == i + 11)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw10)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw10)
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
                        else if (j == i + 12)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw10)
                                {

                                    if (y == j + x)
                                    {
                                        foreach (int z in raw10)
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

                    else if (i == 98)
                    {
                        if (j == i + 11)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw10)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw10)
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

                    }

                }
            }
        }

        foreach (int i in temp2)
        {
            if (i != 0)
            {
                foreach (int j in raw11)
                {
                    if (i != 109)
                    {
                        if (j == i + 11)
                        {
                            failPanel.SetActive(true);
                            temp2[i] = 0;
                            temp2[j] = j;
                        }
                        else if (j == i + 12)
                        {
                            failPanel.SetActive(true);
                            temp2[i] = 0;
                            temp2[j] = j;
                        }

                    }

                    else if (i == 109)
                    {
                        if (j == i + 11)
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
