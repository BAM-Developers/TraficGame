using UnityEngine;
using System.Collections;

public class FadeEffect : MonoBehaviour {

	public IEnumerator ChangeLevel()
	{
		float fadeTime = GameObject.Find ("Menu").GetComponent<FadeIn> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		Application.LoadLevel (1);
	}



}
