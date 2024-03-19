using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 torque, angularV;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ShowInertia();

        if (Input.GetMouseButtonDown(0))
        {
            RotateAngularV();
        }
        if (Input.GetMouseButtonDown(1))
        {
            RotateTorque();
        }
    }
    void ShowInertia()
    {
        Debug.Log(this.name + "Inertia :" + rb.inertiaTensor);
        rb.angularVelocity = rb.inertiaTensor;

        transform.localScale += new Vector3(Input.GetAxis("Horizontal"),0,0);

    }
    private void RotateTorque()
    {
        rb.AddTorque(torque);
    }

    private void RotateAngularV()
    {
        rb.angularVelocity = angularV;
    }
}
