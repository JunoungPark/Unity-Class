using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //            �� (0,0,1) 
        // (-1,0,0)��      ��(1,0,0)
        //            �� (0,0,-1 * 3)

        // Horizontal : ���� ���� ������ -1 ~ 1 ������ ���� ��ȯ�մϴ�.

        // Vertical : ������ ���� ������ -1 ~ 1 ������ ���� ��ȯ�մϴ�.
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0, z);

        // Ư�� ������ �� �����Ӹ��� �̵��ϴ� �Լ��Դϴ�.
        // normalizedf�� ����ؼ� ���� ���͸� ������ݴϴ�.
        // ������ ũ�⸦ 1�� ����� �ݴϴ�.

        transform.Translate(dir.normalized * speed * Time.deltaTime);
    }

}
