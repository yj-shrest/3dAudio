using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public CharacterController control;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {   
        
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        float movex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");
        Vector3 move =- transform.right * movey*speed + transform.forward * movex*speed;
        control.Move(move);

    }
}
