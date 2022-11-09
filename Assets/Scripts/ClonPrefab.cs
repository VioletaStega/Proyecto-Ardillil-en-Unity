using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonPrefab : MonoBehaviour
{
    //Aquí le indico el prefab que quiero clonar.
    public GameObject _object;
    //Aquí indico la posición donde quiero que aparezcan los clones del prefab.
    public Transform transformChild;

    public float thrust;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Llama al método CreateObjects transcurridos 5 segundos.
            InvokeRepeating("CreateObjects", 1, 3);
        }
    }

    private void CreateObjects()
    {   
        //Creo mi variable donde guardaré mis clones del prefab (mis bellotitas).
        GameObject cloneBall = Instantiate(_object, transformChild.position, transformChild.rotation);
        //Le aplico a mis bellotitas el componente Rigidbody, para después aplicarlse fuerza.
        Rigidbody rbBall = cloneBall.GetComponent<Rigidbody>();
        //Destruyeme todos los clones del prefab (mis bellotas) pasados 5 segundos.
        Destroy(cloneBall, 5);
        
        rbBall.AddForce(Vector3.up * 100);
        rbBall.AddForce(transform.forward * thrust);
    }
}
