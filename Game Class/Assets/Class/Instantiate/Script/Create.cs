using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject obj;

    // [ ]  [ ]  [ ] ����
    // ??   ??   ?? <- �ı��� �� ������ 
    // ������ �÷��Ͷ�� �� ������ �ؼ� ���� �ֱ⸶�� ������ �մϴ�.

 
    void Start()
    {
        // ������ ���� ������Ʈ, ��ġ, ȸ��
        // Quaternion.identity = ȸ������ 0,0,0���� �ʱ�ȭ�մϴ�.

        for(int i = 1; i <= 3; i++)
        {
            Instantiate(obj, new Vector3(3 * i, 0, 0), Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
