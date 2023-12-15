using System;
using TMPro;
using UnityEngine;

public class BestPointsCounter : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        if(PlayerPrefs.HasKey("BestScore"))
            _text.text = "Best score: " + PlayerPrefs.GetFloat("BestScore");
        else
            _text.text = "Best score: 0";
    }
}