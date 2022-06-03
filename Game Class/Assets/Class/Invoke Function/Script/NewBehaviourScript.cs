using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Awake �Լ��� Start �Լ� ������ �� ���� ȣ��Ǵ� �Լ��Դϴ�.
    private void Awake()
    {
        Debug.Log("Awake �Լ��Դϴ�.");
    }

    // Start �Լ��� ���� ������ �� �� ���� ȣ��Ǵ� �Լ��Դϴ�.
    void Start()
    {
        // ȣ���� �Լ��� �̸��� �� ���Ŀ� �Լ��� ������ �� �������ְ� �� �ʸ��� �ݺ��� ������ �����մϴ�.
        InvokeRepeating("AutoMove", 0, 1);

        // �ڱ� �ڽ��� ��ġ�� �����մϴ�.
        /*
        transform.position = new Vector3
        (
            transform.position.x,
            transform.position.y,
            transform.position.z + 1
        );
        */
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            // Vector3.left = (-1,0,0);

            // 60 �������� �� : left + ������ �ӵ� * 0.016
            // 30 �������� �� : left + ������ �ӵ� * 0.03
            transform.position += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            // Vector3.forward = (0,0,1);
            transform.position += Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Vector3.back = (0,0,-1);
            transform.position += Vector3.back * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Vector3.right = (1,0,0);
            transform.position += Vector3.right * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke("AutoMove");
        }
    }

    public void AutoMove()
    {
        transform.position = new Vector3
            (
               Random.Range(0, 5),
               0,
               Random.Range(0, 5)
            );

        Debug.Log("����");
    }
}
