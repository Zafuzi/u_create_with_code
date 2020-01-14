using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    private float max_height = 3.0f;
    private int move_dir = 1;
    public float speed = 3.0f;
    private Vector3 start_pos;
    // Start is called before the first frame update
    void Start()
    {
        start_pos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
       if(start_pos.y - transform.position.y > max_height || start_pos.y - transform.position.y < -max_height)
        {
            move_dir *= -1;
        }

        transform.Translate(Vector3.up * move_dir * speed * Time.deltaTime, Space.World);
    }
}
