using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidBody;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //ForceMode.Force : �������� ���� ���� ���� ������Ʈ�� �����̴� ��� (���� ����)
        //ForceMode.Acceleration : �������� ���� ���� ���� ������Ʈ�� �����̴� ��� (���� x)
        //ForceMode.Impulse : �������� ���� ���� ���� ������Ʈ�� �����̴� ��� (���� ����)
        //ForceMode.VelocityChange : �������� ���� ���� ���� ������Ʈ�� �����̴� ��� (���� x)

        rigidBody.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.Impulse);
    }
}
