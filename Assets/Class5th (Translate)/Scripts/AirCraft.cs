using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCraft : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed=1.0f;

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction.Normalize();
        //������ ����ȭ(�밢�� �ӵ�)

        //P=P0+vt
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
