using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{

    private PlayerInput _input;

    private Rigidbody _rigidbody;

    public float Speed = 20f;
    public bool UseSpeed = false;

   
    void Start()
    {
        // _input �� ���� �Ҵ�.
        _input = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = _input.X * Speed;
        float zSpeed = _input.Y * Speed;

        if (UseSpeed)
        {
            _rigidbody.velocity = new Vector3(xSpeed, 0f, zSpeed);
        }

        else
        {
            //// �� ���⿡ ���� ���� ����.
            _rigidbody.AddForce(xSpeed, 0f, zSpeed);

        }



    }
}
