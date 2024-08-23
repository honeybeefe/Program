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
        switch(state)//C# break 안쓰면 에러
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
        //OnTriggerEnter(): 게임 오브젝트가 물리적이지 않은 충돌을 했을 때 호출되는 이벤트 함수

        
    }

    private void OnTriggerStay(Collider other)
    {
        //OnTriggerStay(): 게임 오브젝트가 물리적이지 않은 충돌 중일 때 호출되는 이벤트 함수
        
    }

    private void OnTriggerExit(Collider other)
    {
        //OnTriggerExit(): 게임 오브젝트가 물리적이지 않을 충돌이 벗어났을 때 호출되는 이벤트 함수
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //OnCollisionEnte(): 게임 오브젝트가 물리적인 충돌을 했을 때 호출되는 이벤트 함수
        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        //OnCollisionStay(): 게임 오브젝트가 물리적인 충돌 중일 때 호출되는 이벤트 함수
        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        //OnCollisionExit(): 게임 오브젝트가 물리적인 충돌을 벗어났을 때 호출되는 이벤트 함수
        Debug.Log("OnCollisionExit");
    }
}
