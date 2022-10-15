using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotOneQuantum : MonoBehaviour
{
    [SerializeField] private Object _quantum;
    
    public void OnClick()
    {
        Instantiate(_quantum);
    }
}
