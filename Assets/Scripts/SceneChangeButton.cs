using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChangeButton : MonoBehaviour
{
	[SerializeField]
	private string _targetScene;
	
	private void Start()
	{
		GetComponent<Button>().onClick.AddListener(GoToScene);
	}

	private void GoToScene()
	{
		SceneManager.LoadScene(_targetScene);
	}
}