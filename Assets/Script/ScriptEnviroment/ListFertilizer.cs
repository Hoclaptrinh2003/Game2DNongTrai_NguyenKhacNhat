using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class ListFertilizer 
{
    public string name_fertilizer;
    public int number_fertilizer;

    public ListFertilizer(string name, int number)
    {
        name_fertilizer = name;
        number_fertilizer = number;
    }
}
