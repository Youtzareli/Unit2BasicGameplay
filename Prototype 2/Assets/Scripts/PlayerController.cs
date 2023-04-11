using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float horizontalInput;
    public float speed = 10.0f;
    public float XRange = 10;
    public GameObject ProjectilePrefab;
    // Update is called once per frame
    void Update()
    {
       // Keep Player in bounds
        if (transform.position.x < -XRange)
        {
            transform.position = new Vector3(-XRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > XRange)
        {
            transform.position = new Vector3(XRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
