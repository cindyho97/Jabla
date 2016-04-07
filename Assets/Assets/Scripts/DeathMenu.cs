﻿using UnityEngine;
using System.Collections;

public class DeathMenu : MainMenu {

    public GameObject deathMenuCanvas; // death menu screen
    public bool isDead;


    public void PlayerDead()
    {
        if(isDead)
        {
            deathMenuCanvas.SetActive(true); // show death menu
        }
        else
        {
            deathMenuCanvas.SetActive(false); 
        }
    }
    
}