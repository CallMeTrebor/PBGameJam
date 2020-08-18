using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Audio
{

	public AudioClip clip;

	public string name;

	[Range(0f, 1.0f)]
	public float volume;

	[Range(.1f, 3.0f)]
	public float pitch;

	[HideInInspector]
	public AudioSource source;
}
