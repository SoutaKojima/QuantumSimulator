using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Quantum : MonoBehaviour
{
    [SerializeField]private float _alpha;
    private float _beta;
    void Awake()
    {
        _alpha = Random.Range(0f, 1f);
        _beta = 1 - _alpha;
    }
    
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0f, 1f, 0f) * Time.deltaTime);
        transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime;
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.transform.CompareTag("Observer"))
        {
            
        }
    }
}
