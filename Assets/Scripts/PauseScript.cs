using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
	bool isPaused = false;

	public void pauseGame()
	{
		if (isPaused)
		{
			Time.timeScale = 1;
			isPaused = false;
			AudioListener.volume = 1;
		}
		else
		{
			Time.timeScale = 0;
			isPaused = true;
			AudioListener.volume = 0;
		}
	}
}
