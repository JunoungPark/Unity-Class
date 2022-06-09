using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Character;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Character.transform.position) > 5) 
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
          
        }
        else
            transform.LookAt(Character.transform);
    }
}
