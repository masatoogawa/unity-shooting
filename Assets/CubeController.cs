using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //_rigidbody.AddForce(-5 * _rigidbody.velocity);
        
    }
    void FixedUpdate() {
        _rigidbody.AddForce(50 * _rigidbody.velocity);
    }
}
