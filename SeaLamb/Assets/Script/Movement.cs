using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    protected Joystick joystick;
    protected buttonjoy joybutton;
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<buttonjoy>();
    }
   
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal*100f*Time.deltaTime,rigidbody.velocity.y*100f*Time.deltaTime,joystick.Vertical*100f*Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="varil")
        {
            TextToplam.skor += 1;
            Destroy(other.gameObject);
        }
    }
}
