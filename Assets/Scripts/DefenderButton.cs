﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>(); // finds all objects with DefenderButton script attached to them
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255); //greys out all DefenderButtons
        }

        GetComponent<SpriteRenderer>().color = Color.white;//after all DefenderButtons have their colors reset by the above instructions, this commands brightens the button being clicked on
    }
}
