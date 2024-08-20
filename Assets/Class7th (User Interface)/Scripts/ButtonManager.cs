using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Text[] buttonTexts;
    [SerializeField] string [] buttonNames;
    

    void Start()
    {
        for (int i= 0; i< buttonTexts.Length; i++)
        {
            buttonTexts[i].text = buttonNames[i];
        }
    }

    public void NewGame()
    {
        Debug.Log("New Game");
    }

    public void Continue()
    {
        Debug.Log("Continue");
    }

    public void Exit()
    {
        Debug.Log("Exit");
    }
}
