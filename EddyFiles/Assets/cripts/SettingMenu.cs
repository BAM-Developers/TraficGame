using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class SettingMenu : MonoBehaviour {
	public AudioMixer mixer;
	public void setVolume(float volume)
	{

		mixer.SetFloat ("volume", volume);

	}

	public void SetQuality(int qualityIndex)
	{
		QualitySettings.SetQualityLevel (qualityIndex);
	}
}
