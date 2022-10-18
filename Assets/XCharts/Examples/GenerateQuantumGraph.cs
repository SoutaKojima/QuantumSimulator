using System.Collections;
using UnityEngine;
using XCharts.Runtime;

namespace XCharts.Example
{
    [DisallowMultipleComponent]
    public class GenerateQuantumGraph : MonoBehaviour
    {
        private BarChart chart;
        private Serie serie, serie2;
        private int m_DataNum = 2;

        void Start()
        {
            RefreshGraph();
        }

        private void OnEnable()
        {
            RefreshGraph();
        }

        public void RefreshGraph()
        {
            chart = gameObject.GetComponent<BarChart>();
            if (chart == null) chart = gameObject.AddComponent<BarChart>();
            chart.GetChartComponent<Title>().text = "Quantum";

            var yAxis = chart.GetChartComponent<YAxis>();
            yAxis.minMaxType = Axis.AxisMinMaxType.Custom;
            yAxis.min = 0f;
            yAxis.max = 100f;

            chart.RemoveData();
            serie = chart.AddSerie<Bar>("Probability");

            if (PlayerPrefs.GetInt("zero_ket") + PlayerPrefs.GetInt("one_ket") != 0)
            {
                float sum = PlayerPrefs.GetInt("zero_ket") + PlayerPrefs.GetInt("one_ket");
                chart.AddXAxisData("0");
                chart.AddData(0, 100f*PlayerPrefs.GetInt("zero_ket")/sum);
                chart.AddXAxisData("1");
                chart.AddData(0, 100f*PlayerPrefs.GetInt("one_ket")/sum);
            }
            else
            {
                chart.AddXAxisData("0");
                chart.AddData(0, PlayerPrefs.GetInt("zero_ket"));
                chart.AddXAxisData("1");
                chart.AddData(0, PlayerPrefs.GetInt("one_ket"));
            }
        }
    }
}