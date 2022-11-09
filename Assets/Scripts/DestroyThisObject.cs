using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThisObject : MonoBehaviour
{
    public GameObject _object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DestroyObject();
        }
    }

    void DestroyObject()
    {
        Destroy(_object, 5);
    }
}
