using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject Prefab;

    // [ ]  [ ]  [ ] 생성
    // ??   ??   ?? <- 파괴가 된 가비지 
    // 가비지 컬렉터라는 게 동작을 해서 일정 주기마다 해제를 합니다.
    public void PrefabCreate() 
    {
        ObjectPool.objpool.GetQueue();
    }
  
}
