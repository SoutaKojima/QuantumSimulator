using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Quantum : MonoBehaviour
{
    [SerializeField]private float _alpha;
    private float _beta;
    private float _speed;
    void Awake()
    {
        _alpha = Random.Range(0f, 1f);
        _beta = 1 - _alpha;
        _speed = 3f;
    }
    
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0f, 1f, 0f) * _speed * Time.deltaTime);
        transform.position += new Vector3(1f, 0f, 0f) * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Observer"))
        {
            if (_alpha > 0.5f)
            {
                transform.Translate(new Vector3(0f, 2f, 0f));
            }
            else
            {
                transform.Translate(new Vector3(0f, -2f, 0f));
            }
        }
    }
}
