using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("It's a Bed");
    }
}
