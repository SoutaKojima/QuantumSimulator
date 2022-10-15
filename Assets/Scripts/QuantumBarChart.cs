using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using XCharts;
using XCharts.Runtime;

public class QuantumBarChart : MonoBehaviour
{
    [SerializeField]private BarChart _barChart;
    
    // Start is called before the first frame update
    void Start()
    {
        _barChart.series[0].ClearData();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
