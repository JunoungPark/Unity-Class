using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool objpool;
    // Start is called before the first frame update
    public GameObject prefab;

    public Queue<GameObject> queue = new Queue<GameObject>();

    Rigidbody rigid;
    void Start()
    {
        objpool = this;

        for (int i = 0; i < 10; i++)
        {
            GameObject tempPrefab = Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
            queue.Enqueue(tempPrefab);
            tempPrefab.gameObject.SetActive(false);
        }
    }
    public void InsertQueue(GameObject pobj) 
    {
        queue.Enqueue(pobj);
        pobj.gameObject.SetActive(false);
    }
    // Update is called once per frame
    public GameObject GetQueue() 
    {
        GameObject tempPrefab = queue.Dequeue();
        rigid = tempPrefab.GetComponent<Rigidbody>();
        rigid.velocity = Vector3.zero;
        tempPrefab.gameObject.transform.position =new Vector3(0,5,0);
        tempPrefab.gameObject.SetActive(true);

        return tempPrefab;
    }
}
