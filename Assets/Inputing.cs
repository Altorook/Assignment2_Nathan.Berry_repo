using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputing : MonoBehaviour
{
    float lastMouseY;
    float lastMouseX;
    IInputTime inputInt;
    private void Start()
    {
        if (gameObject.GetComponent<IInputTime>() != null)
        {
            inputInt = gameObject.GetComponent<IInputTime>();
        }
    }
    void Update()
    {
            inputInt.IntInputing(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X")); 
    }
}
