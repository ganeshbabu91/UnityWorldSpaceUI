using UnityEngine;
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
            Application.LoadLevel(2);
        }
        else if (buttonName.Equals("backscene"))
        {
            Debug.Log("Back button in menu scene clicked");
            Application.LoadLevel(0);
        }
        else if (buttonName.Equals("startapp"))
        {
            Debug.Log("Get started button clicked");
            Application.LoadLevel(1);
        }
        else if (buttonName.Equals("video"))
        {
            Debug.Log("help video button clicked");
            Application.LoadLevel(2);
        }
    }
}
