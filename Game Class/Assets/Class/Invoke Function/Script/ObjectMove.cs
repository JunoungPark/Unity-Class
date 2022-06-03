using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public GameObject target;
    private float speed = 1.0f;

    private MeshRenderer render;

    private void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Transform ������Ʈ�� �����ؼ� ��ġ�� �����ɴϴ�. 
        transform.position = Vector3.MoveTowards
        (
            transform.position,         // ���� �ڱ� �ڽ��� ��ġ
            target.transform.position,  // ��ǥ�� ���� ������Ʈ�� ��ġ
            speed * Time.deltaTime      // ���� ��ġ���� ��ǥ ��ġ�� �̵��� �ӵ�
        );

        // Ű�� ������ �� �����մϴ�.
        // KeyCode.Return = Enter
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Invoke("Paint", 3);
        }
    }

    public void Paint()
    {
        // Random.Range(?,?) ?�� ?-1 ������ �������� ��ȯ�ϴ� Ŭ�����Դϴ�.
        int value = Random.Range(0, 3);

        switch (value)
        {
            case 0 :
                // render��� ������ ��Ƽ���� ������ �ʷϻ����� �����մϴ�.
                render.material.color = Color.green;
                break;
            case 1 :
                // render��� ������ ��Ƽ���� ������ ���������� �����մϴ�.
                render.material.color = Color.red;
                break;
            case 2:
                // render��� ������ ��Ƽ���� ������ ���������� �����մϴ�.
                render.material.color = Color.black;
                break;
        }
    }
}
