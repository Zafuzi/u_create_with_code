using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float h_input;
    public float move_speed = 5.0f;
    private Vector3 speed = new Vector3(0,0,0);
    public Rigidbody rb;
    //private float v_input;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = rb.velocity;
        h_input = Input.GetAxis("Horizontal");
        transform.Translate( new Vector3(1,0,0) * h_input * move_speed * Time.deltaTime, Space.World);
    }
}
