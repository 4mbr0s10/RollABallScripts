using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public GameObject bullet;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;
        tilt = Quaternion.Euler(0, 0, 0) * tilt;

        rb.AddForce(tilt * speed);

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Instantiate(bullet, this.transform.position, bullet.transform.rotation);

        }
    }
}
