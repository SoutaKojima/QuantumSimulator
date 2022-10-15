using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateContinuousQuantum : MonoBehaviour
{
    public Toggle _toggle;
    [SerializeField] private Object _quantum;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(GenerateQuantum),0f,0.2f);
    }

    public void GenerateQuantum()
    {
        if (_toggle.isOn)
        {
            Instantiate(_quantum);
        }
    }
}
