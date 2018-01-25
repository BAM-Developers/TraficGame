using UnityEngine;
using System.Collections;

public class CarMotion : MonoBehaviour {
	public float Speed;

	public void Start()
	{
		Speed = 30f;
		//StartCoroutine ("CountDown");
	}

	public void Update()
	{
		//for (int i = 0; i <= 100; i++) {
			transform.Translate (Speed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, Speed * Input.GetAxis ("Vertical") * Time.deltaTime);
			//Speed++;
	//	}
		}

}
