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
        Debug.Log("Has pulsado con el botón izquierdo del ratón.");
    }

    private void OnMouseUp()
    {
        Debug.Log("Has soltado el botón izquierdo del ratón.");
    }

    private void OnMouseEnter()
    {
        Debug.Log("Has pasado el ratón por encima del GameObject.");
    }

    private void OnMouseDrag()
    {
        Debug.Log("Estás arrastrando el cursor del ratón.");
    }

}
