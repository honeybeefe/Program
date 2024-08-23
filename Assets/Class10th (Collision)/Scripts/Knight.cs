using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    [SerializeField] State state;

    public enum State
    {
        WALK,
        ATTACK,
        DIE
    }

    void Start()
    {
        
    }

    void Update()
    {
        switch(state)//C# break �Ⱦ��� ����
        {
            case State.WALK:Walk();
                break;
            case State.ATTACK:Attack();
                break;
            case State.DIE:Die();
                break;
        }
    }

    public void Walk()
    {
        Debug.Log("Walk");
    }

    public void Attack()
    {
        Debug.Log("Attack");
    }

    public void Die()
    {
        Debug.Log("Die");
    }

    private void OnTriggerEnter(Collider other)
    {
        //OnTriggerEnter(): ���� ������Ʈ�� ���������� ���� �浹�� ���� �� ȣ��Ǵ� �̺�Ʈ �Լ�

        
    }

    private void OnTriggerStay(Collider other)
    {
        //OnTriggerStay(): ���� ������Ʈ�� ���������� ���� �浹 ���� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        
    }

    private void OnTriggerExit(Collider other)
    {
        //OnTriggerExit(): ���� ������Ʈ�� ���������� ���� �浹�� ����� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //OnCollisionEnte(): ���� ������Ʈ�� �������� �浹�� ���� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        //OnCollisionStay(): ���� ������Ʈ�� �������� �浹 ���� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        //OnCollisionExit(): ���� ������Ʈ�� �������� �浹�� ����� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnCollisionExit");
    }
}
