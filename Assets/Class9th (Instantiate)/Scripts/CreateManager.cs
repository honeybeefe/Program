using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject [] foods;
    [SerializeField] GameObject clone;
    [SerializeField] int count = 0;

    WaitForSeconds waitForSeconds = new WaitForSeconds(3.0f);


    IEnumerator Create()
    {
        while(count<foods.Length)
        {
            if (clone == null)
            {
               clone= Instantiate(foods[count++]);
            }
            yield return waitForSeconds;
        }
    }
}