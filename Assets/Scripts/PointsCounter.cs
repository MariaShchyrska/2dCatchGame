using System;
using TMPro;
using UnityEngine;

public class PointsCounter : MonoBehaviour
{
    [SerializeField]
    private Collector _collector;
    private TextMeshProUGUI _text;

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        _text.text = "Score: " + _collector.Points;
    }
}