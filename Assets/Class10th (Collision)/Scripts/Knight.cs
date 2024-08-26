using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    [SerializeField] State state;
    [SerializeField] float speed = 2.5f;
    private WaitForSeconds waitForSeconds = new WaitForSeconds(5.0f);
    [SerializeField] Animator animator;

    public enum State
    {
        WALK,
        ATTACK,
        DIE
    }

    void Start()
    {
        state = State.WALK;
        animator = GetComponent<Animator>();
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
        animator.SetBool("Attack", false);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Attack()
    {
        animator.SetBool("Attack", true);
    }

    public void Die()
    {
        animator.Play("Die");
    }

    private IEnumerator KnockBack(Collider other)
    {
        yield return waitForSeconds;//��ٸ��� �ð�

        other.transform.position += new Vector3(0, 0, -3);//���� ��ġ�� ����

    }

    private void OnTriggerEnter(Collider other)
    {
        //OnTriggerEnter(): ���� ������Ʈ�� ���������� ���� �浹�� ���� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        state = State.ATTACK;

        StartCoroutine(KnockBack(other));
    }

    private void OnTriggerStay(Collider other)
    {
        //OnTriggerStay(): ���� ������Ʈ�� ���������� ���� �浹 ���� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        
    }

    private void OnTriggerExit(Collider other)
    {
        //OnTriggerExit(): ���� ������Ʈ�� ���������� ���� �浹�� ����� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        state = State.DIE;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //OnCollisionEnter(): ���� ������Ʈ�� �������� �浹�� ���� �� ȣ��Ǵ� �̺�Ʈ �Լ�
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