using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Quantum : MonoBehaviour
{
    [SerializeField]private float _alpha;
    private float _speed;

    private float _angle;
    void Awake()
    {
        _alpha = Random.Range(0f, 1f);
        _speed = 3f;
        _angle = 0f;
        Destroy(this.gameObject, 5.0f);
        PlayerPrefs.SetInt("zero_ket",0);
        PlayerPrefs.SetInt("one_ket", 0);
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
                int tmp = PlayerPrefs.GetInt("zero_ket");
                //PlayerPrefs.SetInt("zero_ket",tmp+1);
            }
            else
            {
                _angle = -0.25f;
                int tmp = PlayerPrefs.GetInt("one_ket");
                //PlayerPrefs.SetInt("one_ket",tmp+1);
            }
        }
    }
}
