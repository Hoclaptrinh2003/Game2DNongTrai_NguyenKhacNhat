using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class ListSeed
{


    public string name_seed;
    public int number_seed;


    public ListSeed(string name, int number)
    {
        name_seed = name;
        number_seed = number;
    }

}
