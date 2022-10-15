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

    private float _angle;
    void Awake()
    {
        _alpha = Random.Range(0f, 1f);
        _beta = 1 - _alpha;
        _speed = 3f;
        _angle = 0f;
        Destroy(this.gameObject,5.0f);
    }
    
    void FixedUpdate()
    {
        //transform.Rotate(new Vector3(0f, 1f, 0f) * _speed * Time.deltaTime);
        transform.position += new Vector3(1f, _angle, 0f) * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Observer"))
        {
            if (_alpha > 0.5f)
            {
                _angle = 0.25f;
            }
            else
            {
                _angle = -0.25f;
            }
        }
    }
}
