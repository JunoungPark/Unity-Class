using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject Prefab;

    // [ ]  [ ]  [ ] ����
    // ??   ??   ?? <- �ı��� �� ������ 
    // ������ �÷��Ͷ�� �� ������ �ؼ� ���� �ֱ⸶�� ������ �մϴ�.
    public void PrefabCreate() 
    {
        ObjectPool.objpool.GetQueue();
    }
  
}
