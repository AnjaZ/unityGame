using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeValue : MonoBehaviour
{
	private AudioSource audioSrc;
	private float musicVolume = 1f;

	void Start()
	{
		audioSrc = GetComponent<AudioSource>();
	}

	void FixedUpdate()
	{
		audioSrc.volume = musicVolume;
	}

	public void SetVolume(float vol)
	{
		musicVolume = vol;
	}


}
