using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject food;
    [SerializeField] GameObject clone;
    [SerializeField] float time;

    void Start()
    {
        clone=  Instantiate(food); //오브젝트 생성함수
        clone.transform.position = Vector3.one;
    }

    
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 5.0f) 
        {
            clone=Instantiate(food);
            time = 0.0f;
        }
    }
}
