using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeppelinMovement : MonoBehaviour
{

    public float speed;
    private Rigidbody2D body; 
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            body.transform.position += Vector3.up * speed * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            body.transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}
