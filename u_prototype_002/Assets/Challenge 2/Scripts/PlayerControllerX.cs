using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool can_spawn = true;
    public GameObject[] alive_dogs;
    private int max_dogs = 3;
    private int dog_index = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Okay");
            dog_index++;
            if (dog_index == max_dogs) dog_index = 0;
            if (alive_dogs[dog_index] == null)
            {
                alive_dogs[dog_index] = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }
}
