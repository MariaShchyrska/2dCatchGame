using System;
using UnityEngine;

public class Pauser : MonoBehaviour
{
    [SerializeField]
    private GameObject _pauseWindow;

    private bool _paused = false;

    private void Start()
    {
        Resume();
    }

    public void Pause()
    {
        if(!_paused)
        {
            _paused = true;
            _pauseWindow.SetActive(true);
            Time.timeScale = 0;
        }
    }
    
    public void Resume()
    {
        _paused = false;
        _pauseWindow.SetActive(false);
        Time.timeScale = 1;
    }
}