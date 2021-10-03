using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterControl : MonoBehaviour
{
    public float speed;    
    public float Salto = 10f;
    public float timer = 2;
    Rigidbody rigidbody;
    public Transform start;
    public Transform end;
    public float delay;
    public bool siSalta;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    void Update ()
    {
        //float x = Input.GetAxis("Vertical");
        //float y = Input.GetAxis("Horizontal");
        //if (x != 0 || y != 0)
        //{
        //    PlayerMovement();
        //}
        PlayerMovement();
    }

    void PlayerMovement()
    {
        //Rigid.MoveRotation(Rigid.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * MouseSensitivity, 0)));
        Vector3 v = (transform.position + (transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime) + (transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime));
        delay -= Time.deltaTime;
        //rigidbody.velocity = v;
        rigidbody.MovePosition(v);
        if (Input.GetKeyDown(KeyCode.Space) && (Physics.Linecast(start.position, end.position) || siSalta))
        {
            rigidbody.AddForce(transform.up * Salto);
            siSalta = false;
            delay = timer;
        }
        else if(delay < 0)
        {
            siSalta = true;
        }
    }
}