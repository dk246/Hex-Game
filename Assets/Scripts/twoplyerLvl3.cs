using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class twoplyerLvl3 : MonoBehaviour
{
    public GameObject[] all;
    public GameObject[] allred;
    public int[] col1 = new int[19];
    public int[] col2 = new int[19];
    public int[] col3 = new int[19];
    public int[] col4 = new int[19];
    public int[] col5 = new int[19];
    public int[] col6 = new int[19];
    public int[] col7 = new int[19];
    public int[] col8 = new int[19];
    public int[] col9 = new int[19];
    public int[] col10 = new int[19];
    public int[] col11 = new int[19];
    public int[] col12 = new int[19];
    public int[] col13 = new int[19];
    public int[] col14 = new int[19];
    public int[] col15 = new int[19];
    public int[] col16 = new int[19];
    public int[] col17 = new int[19];
    public int[] col18 = new int[19];
    public int[] col19 = new int[19];


    public int[] raw1 = new int[19];
    public int[] raw2 = new int[19];
    public int[] raw3 = new int[19];
    public int[] raw4 = new int[19];
    public int[] raw5 = new int[19];
    public int[] raw6 = new int[19];
    public int[] raw7 = new int[19];
    public int[] raw8 = new int[19];
    public int[] raw9 = new int[19];
    public int[] raw10 = new int[19];
    public int[] raw11 = new int[19];
    public int[] raw12 = new int[19];
    public int[] raw13 = new int[19];
    public int[] raw14 = new int[19];
    public int[] raw15 = new int[19];
    public int[] raw16 = new int[19];
    public int[] raw17 = new int[19];
    public int[] raw18 = new int[19];
    public int[] raw19 = new int[19];

    public GameObject panel;
    public GameObject failPanel;
    public int[] temp = new int[361];
    public int[] temp2 = new int[361];
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
        button1.btnclick = 0;
        SceneManager.LoadScene(5);
    }


    void Update()
    {
        //foreach (int i in temp)
        //{
        //    if (i > 341)
        //    {
        //        panel.SetActive(true);
        //    }
        //}
        foreach (int i in col1)
        {
            if (i != -1)
            {
                foreach (int j in col2)
                {
                    if (i != 18)
                    {
                        if (j == i + 19)
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

                                }
                            }
                        }
                        else if (j == i + 20)
                        {
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col2)
                                {
                                    print("in" + y);
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

                    else if (i == 18)
                    {
                        if (j == i + 19)
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
                    if (i != 37)
                    {
                        if (j == i + 19)
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
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col3)
                                {
                                    print("in" + y);
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

                    else if (i == 37)
                    {
                        if (j == i + 19)
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
                    if (i != 56)
                    {
                        if (j == i + 19)
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
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col4)
                                {
                                    print("in" + y);
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

                    else if (i == 56)
                    {
                        if (j == i + 19)
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
                    if (i != 75)
                    {
                        if (j == i + 19)
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
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col5)
                                {
                                    print("in" + y);
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

                    else if (i == 75)
                    {
                        if (j == i + 19)
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
                    if (i != 94)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
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
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col6)
                                {
                                    print("in" + y);
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

                    else if (i == 94)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
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
                foreach (int j in col7)
                {
                    if (i != 113)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
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
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col7)
                                {
                                    print("in" + y);
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

                    else if (i == 113)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
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
                foreach (int j in col8)
                {
                    if (i != 132)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
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
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col8)
                                {
                                    print("in" + y);
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

                    else if (i == 132)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
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
                foreach (int j in col9)
                {
                    if (i != 151)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
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
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col9)
                                {
                                    print("in" + y);
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

                    else if (i == 151)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
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
                foreach (int j in col10)
                {
                    if (i != 170)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
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
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col10)
                                {
                                    print("in" + y);
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

                    else if (i == 170)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
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
                foreach (int j in col11)
                {
                    if (i != 189)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col11)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col11)
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
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col11)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in col11)
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

                    else if (i == 189)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;

                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col11)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col11)
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
                foreach (int j in col12)
                {
                    if (i != 208)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col12)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col12)
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
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col12)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in col12)
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

                    else if (i == 208)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col12)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col12)
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
                foreach (int j in col13)
                {
                    if (i != 227)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col13)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col13)
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
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col13)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in col13)
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

                    else if (i == 227)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col13)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col13)
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
                foreach (int j in col14)
                {
                    if (i != 246)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col14)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col14)
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
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col14)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in col14)
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

                    else if (i == 246)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col14)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col14)
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
                foreach (int j in col15)
                {
                    if (i != 265)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col15)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col15)
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
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col15)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in col15)
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

                    else if (i == 265)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col15)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col15)
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
                foreach (int j in col16)
                {
                    if (i != 284)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col16)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col16)
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
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col16)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in col16)
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

                    else if (i == 284)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col16)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col16)
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
                foreach (int j in col17)
                {
                    if (i != 303)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col17)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col17)
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
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col17)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in col17)
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

                    else if (i == 303)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col17)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col17)
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
                foreach (int j in col18)
                {
                    if (i != 322)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col18)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col18)
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
                        else if (j == i + 20)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in col18)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in col18)
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

                    else if (i == 322)
                    {
                        if (j == i + 19)
                        {
                            temp[i] = 0;
                            temp[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in col18)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in col18)
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
                foreach (int j in col19)
                {

                    if (i != 341)
                    {

                        if (j == i + 19)
                        {
                            print("winnnn");
                            panel.SetActive(true);
                            temp[i] = 0;
                            temp[j] = j;
                        }
                        else if (j == i + 20)
                        {
                            print("winnnn");
                            panel.SetActive(true);
                            temp[i] = 0;
                            temp[j] = j;
                        }

                    }

                    else if (i == 341)
                    {
                        if (j == i + 19)
                        {
                            print("winnnn");
                            panel.SetActive(true);
                            temp[i] = 0;
                            temp[j] = j;
                        }
                        else if (j == i + 18)
                        {
                            print("winnnn");
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

            if (all[i].GetComponent<button1>().behav == 1)
            {

                if (i < 19)
                {
                    col1[i] = i;
                }
                else if (i < 38)
                {
                    col2[i - 19] = i;
                }
                else if (i < 57)
                {
                    col3[i - 38] = i;
                }
                else if (i < 76)
                {
                    col4[i - 57] = i;
                }
                else if (i < 95)
                {
                    col5[i - 76] = i;
                }
                else if (i < 114)
                {
                    col6[i - 95] = i;
                }
                else if (i < 133)
                {
                    col7[i - 114] = i;
                }
                else if (i < 152)
                {
                    col8[i - 133] = i;
                }
                else if (i < 171)
                {
                    col9[i - 152] = i;
                }
                else if (i < 190)
                {
                    col10[i - 171] = i;
                }
                else if (i < 209)
                {
                    col11[i - 190] = i;
                }
                else if (i < 228)
                {
                    col12[i - 209] = i;
                }
                else if (i < 247)
                {
                    col13[i - 228] = i;
                }
                else if (i < 266)
                {
                    col14[i - 247] = i;
                }
                else if (i < 285)
                {
                    col15[i - 266] = i;
                }
                else if (i < 304)
                {
                    col16[i - 285] = i;
                }
                else if (i < 323)
                {
                    col17[i - 304] = i;
                }
                else if (i < 342)
                {
                    col18[i - 323] = i;
                }
                else
                {

                    col19[i - 342] = i;
                }

            }
        }


        for (int i = 0; i < all.Length; i++)
        {

            if (allred[i].GetComponent<button1>().behav == 2)
            {

                if (i < 19)
                {
                    raw1[i] = i;
                }
                else if (i < 38)
                {
                    raw2[i - 19] = i;
                }
                else if (i < 57)
                {
                    raw3[i - 38] = i;
                }
                else if (i < 76)
                {
                    raw4[i - 57] = i;
                }
                else if (i < 95)
                {
                    raw5[i - 76] = i;
                }
                else if (i < 114)
                {
                    raw6[i - 95] = i;
                }
                else if (i < 133)
                {
                    raw7[i - 114] = i;
                }
                else if (i < 152)
                {
                    raw8[i - 133] = i;
                }
                else if (i < 171)
                {
                    raw9[i - 152] = i;
                }
                else if (i < 190)
                {
                    raw10[i - 171] = i;
                }
                else if (i < 209)
                {
                    raw11[i - 190] = i;
                }
                else if (i < 228)
                {
                    raw12[i - 209] = i;
                }
                else if (i < 247)
                {
                    raw13[i - 228] = i;
                }
                else if (i < 266)
                {
                    raw14[i - 247] = i;
                }
                else if (i < 285)
                {
                    raw15[i - 266] = i;
                }
                else if (i < 304)
                {
                    raw16[i - 285] = i;
                }
                else if (i < 323)
                {
                    raw17[i - 304] = i;
                }
                else if (i < 342)
                {
                    raw18[i - 323] = i;
                }
                else
                {

                    raw19[i - 342] = i;
                }

            }
        }




        foreach (int i in raw1)
        {
            if (i != -1)
            {
                foreach (int j in raw2)
                {
                    if (i != 18)
                    {
                        if (j == i + 19)
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
                        else if (j == i + 20)
                        {
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw2)
                                {
                                    print("in" + y);
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

                    else if (i == 18)
                    {
                        if (j == i + 19)
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
                    if (i != 37)
                    {
                        if (j == i + 19)
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
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw3)
                                {
                                    print("in" + y);
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

                    else if (i == 37)
                    {
                        if (j == i + 19)
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
                    if (i != 56)
                    {
                        if (j == i + 19)
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
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw4)
                                {
                                    print("in" + y);
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

                    else if (i == 56)
                    {
                        if (j == i + 19)
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
                    if (i != 75)
                    {
                        if (j == i + 19)
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
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw5)
                                {
                                    print("in" + y);
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

                    else if (i == 75)
                    {
                        if (j == i + 19)
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
                    if (i != 94)
                    {
                        if (j == i + 19)
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
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw6)
                                {
                                    print("in" + y);
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

                    else if (i == 94)
                    {
                        if (j == i + 19)
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
                foreach (int j in raw7)
                {
                    if (i != 113)
                    {
                        if (j == i + 19)
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
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw7)
                                {
                                    print("in" + y);
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

                    else if (i == 113)
                    {
                        if (j == i + 19)
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
                foreach (int j in raw8)
                {
                    if (i != 132)
                    {
                        if (j == i + 19)
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
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw8)
                                {
                                    print("in" + y);
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

                    else if (i == 132)
                    {
                        if (j == i + 19)
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
                foreach (int j in raw9)
                {
                    if (i != 151)
                    {
                        if (j == i + 19)
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
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw9)
                                {
                                    print("in" + y);
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

                    else if (i == 151)
                    {
                        if (j == i + 19)
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
                foreach (int j in raw10)
                {
                    if (i != 170)
                    {
                        if (j == i + 19)
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
                                    else
                                    {
                                        // break;
                                    }
                                }
                            }
                        }
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw10)
                                {
                                    print("in" + y);
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

                    else if (i == 170)
                    {
                        if (j == i + 19)
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
                foreach (int j in raw11)
                {
                    if (i != 189)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw11)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw11)
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
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw11)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in raw11)
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

                    else if (i == 189)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;

                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw11)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw11)
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
                foreach (int j in raw12)
                {
                    if (i != 208)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw12)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw12)
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
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw12)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in raw12)
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

                    else if (i == 208)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw12)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw12)
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
                foreach (int j in raw13)
                {
                    if (i != 227)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw13)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw13)
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
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw13)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in raw13)
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

                    else if (i == 227)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw13)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw13)
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
                foreach (int j in raw14)
                {
                    if (i != 246)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw14)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw14)
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
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw14)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in raw14)
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

                    else if (i == 246)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw14)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw14)
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
                foreach (int j in raw15)
                {
                    if (i != 265)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw15)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw15)
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
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw15)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in raw15)
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

                    else if (i == 265)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw15)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw15)
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
                foreach (int j in raw16)
                {
                    if (i != 284)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw16)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw16)
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
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw16)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in raw16)
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

                    else if (i == 284)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw16)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw16)
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
                foreach (int j in raw17)
                {
                    if (i != 303)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw17)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw17)
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
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw17)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in raw17)
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

                    else if (i == 303)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw17)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw17)
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
                foreach (int j in raw18)
                {
                    if (i != 322)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw18)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw18)
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
                        else if (j == i + 20)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 1; x < 7; x++)
                            {
                                foreach (int y in raw18)
                                {
                                    print("in" + y);
                                    if (y == j + x)
                                    {
                                        foreach (int z in raw18)
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

                    else if (i == 322)
                    {
                        if (j == i + 19)
                        {
                            temp2[i] = 0;
                            temp2[j] = j;
                            for (int x = 0; x < 6; x++)
                            {
                                foreach (int y in raw18)
                                {
                                    if (y == j - x)
                                    {
                                        foreach (int z in raw18)
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
                foreach (int j in raw19)
                {

                    if (i != 341)
                    {

                        if (j == i + 19)
                        {
                            
                            failPanel.SetActive(true);
                            temp2[i] = 0;
                            temp2[j] = j;
                        }
                        else if (j == i + 20)
                        {

                            failPanel.SetActive(true);
                            temp2[i] = 0;
                            temp2[j] = j;
                        }

                    }

                    else if (i == 341)
                    {
                        if (j == i + 19)
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
