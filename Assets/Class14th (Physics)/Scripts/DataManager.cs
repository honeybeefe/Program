using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] int score;

    void Awake()
    {
        Load();
    }

    public void Save()
    {
        PlayerPrefs.Save();
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("Score", score);
    }

    public void Increase()
    {
        score += 10;

        PlayerPrefs.SetInt("Score", score);
    }

    public void Initialized()
    {
        PlayerPrefs.DeleteAll();

        Load();
    }
}