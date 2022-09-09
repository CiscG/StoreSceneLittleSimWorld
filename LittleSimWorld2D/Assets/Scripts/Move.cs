using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 5;
    Vector3 move;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.position = transform.position + speed * move * Time.deltaTime;
    }
}
