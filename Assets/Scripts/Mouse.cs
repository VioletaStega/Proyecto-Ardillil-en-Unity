using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Has pulsado con el bot�n izquierdo del rat�n.");
    }

    private void OnMouseUp()
    {
        Debug.Log("Has soltado el bot�n izquierdo del rat�n.");
    }

    private void OnMouseEnter()
    {
        Debug.Log("Has pasado el rat�n por encima del GameObject.");
    }

    private void OnMouseDrag()
    {
        Debug.Log("Est�s arrastrando el cursor del rat�n.");
    }

}
