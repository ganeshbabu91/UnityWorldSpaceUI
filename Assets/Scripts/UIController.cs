﻿using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour {

	public void ButtonClickHandler(string buttonName)
    {
        Debug.Log("buttonName = "+buttonName);
        if (buttonName.Equals("start"))
        {
            Debug.Log("start clicked");
        }
        else if (buttonName.Equals("cube"))
        {
            Debug.Log("cube clicked");
        }
        else if (buttonName.Equals("help"))
        {
            Debug.Log("help clicked");
        }
    }
}
