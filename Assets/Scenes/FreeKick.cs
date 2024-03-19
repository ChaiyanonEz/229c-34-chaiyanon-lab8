using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeKick : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, angularV;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = velocity;
            rb.angularVelocity = angularV;
        }
        rb.AddForce(Vector3.Cross(rb.velocity,rb.angularVelocity));
    }


}
