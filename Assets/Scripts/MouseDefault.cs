using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDefault : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        Debug.Log("mouse visble");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
