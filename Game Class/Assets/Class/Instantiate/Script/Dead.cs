using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    void OnBecameInvisible()
    {
        ObjectPool.objpool.InsertQueue(gameObject);
        
    }
}
