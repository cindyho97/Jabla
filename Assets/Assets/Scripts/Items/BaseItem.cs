﻿using UnityEngine;
using System.Collections;

public class BaseItem: MonoBehaviour {

    protected string _itemName;
    protected string _itemDescription;//description of the item

    
    //constructors
    public BaseItem()//default
    {
        _itemName = "Most useless item ever";
        _itemDescription = "Well the name explains it...";
    }

    public BaseItem(string name, string description)
    {
        _itemName = name;
        _itemDescription = description;
    }

   
}