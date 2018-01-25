using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GazeLook : MonoBehaviour {
	public float gazeTime=3f;
	private float timer;
	public bool gazeAt;

	public void Start()
	{
	}

	public void Update()
	{
		if (gazeAt) {
			timer += Time.deltaTime;
			if (Input.GetKey (KeyCode.JoystickButton6)) {
			if (timer >= gazeTime) {
				
					ExecuteEvents.Execute (gameObject, new PointerEventData (EventSystem.current), ExecuteEvents.pointerDownHandler);
				}
			}
		}
	}
	public void PointerEnter()
	{
		gazeAt = true;
	}

	public void PointerExit()
	{
		gazeAt = false;
	}

	public void PointerDown()
	{
		
			Application.LoadLevel (1);

	}

	public void Exit()
	{
		Application.Quit();
	}

	public void Change()
	{
		StartCoroutine ("Countdown");

	}
	public IEnumerator Countdown()
	{
		float fadeTime = GameObject.Find ("Menu").GetComponent<FadeIn> ().BeginFade (1);

		yield return new WaitForSeconds (fadeTime);

		PointerDown ();
	}


}
