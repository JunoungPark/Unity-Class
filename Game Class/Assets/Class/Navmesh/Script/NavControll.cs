using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavControll : MonoBehaviour
{
    public float speed;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // �߻縦 ���� �� �ݶ��̴��� �����մϴ�.
             
            // ������ ���� ����(ray), ������ �浹�� ������Ʈ�� ����(hit), ������ �߻� �Ÿ�(Mathf.Infinity)
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Move(hit.point);
            }
        }      
    }

    public void Move(Vector3 direction)
    {
        agent.speed = speed;

        // SetDestination( ) : ������ ������ ������ ����Ǹ�, ���õǾ� �ִ� ���� ������ �̵��ϴ� �Լ��Դϴ�.
        agent.SetDestination(direction);
    }
}
