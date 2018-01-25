using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class GazeAtForCar : MonoBehaviour {
	public float gazeTime=3f;
	private float timer;
	public bool gazeAt;
	public Camera carCamera;
	public Camera sceneCamera;
	public GameObject gameobject;


	public void Start()
	{
		carCamera = carCamera.GetComponent<Camera> ();
		sceneCamera = sceneCamera.GetComponent<Camera> ();
		carCamera.enabled = false;
		//gameobject =gameobject.GetComponent<GameObject> ();
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
		sceneCamera.enabled = false;
		carCamera.enabled = true;
		//Application.LoadLevel (1);
		gameobject.SetActive(true);
		//GetComponent("CarController");

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

	public void PointerDoor()
	{
		sceneCamera.enabled = true;
		carCamera.enabled = false;
		gameObject.SetActive (true);
	}


}
