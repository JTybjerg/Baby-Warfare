using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonControls : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _turnSpeed = 360;
    protected Vector3 _input;

    private void Update()
    {
        GatherInput();
        Look();
    }

    private void FixedUpdate()
    {
        Move();
    }

    protected virtual void GatherInput()
    {
        // Common input gathering logic
    }

    private void Look()
    {
        if (_input != Vector3.zero)
        {
            // Apply isometric skewing to the input vector
            var isoInput = _input.ToIso();

            // Calculate the rotation to look in the direction of the skewed input
            var relative = (transform.position + isoInput) - transform.position;
            var rot = Quaternion.LookRotation(relative, Vector3.up); 

            // Update the rotation gradually
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, _turnSpeed * Time.deltaTime);
        }
    }

    private void Move()
    {
        _rb.MovePosition(transform.position + (transform.forward * _input.magnitude) * _speed * Time.deltaTime);
    }
}
