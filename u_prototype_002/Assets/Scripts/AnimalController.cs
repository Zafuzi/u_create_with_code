using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    private float move_speed = 2.0f;
    private float topBound = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        move_speed *= Random.Range(2.0f, 5.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.forward * move_speed * Time.deltaTime);
    }
}
