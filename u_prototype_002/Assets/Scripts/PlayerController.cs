using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float h_input;
    private float move_speed = 35.0f;
    public float xrange = 20.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xrange) { 
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }

        h_input = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * move_speed * h_input * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from user position
            Vector3 spawn_pos = new Vector3(0,1,0) + transform.position;
            Instantiate(projectilePrefab, spawn_pos, projectilePrefab.transform.rotation);
        }
    }
}
