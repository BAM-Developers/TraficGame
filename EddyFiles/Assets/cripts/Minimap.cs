using UnityEngine;
using System.Collections;

public class Minimap : MonoBehaviour {
	public Transform player;
	void LateUpdate()
	{
		Vector3 newPos = player.position;
		newPos.y = transform.position.y;
		transform.position = newPos;
		transform.rotation = Quaternion.Euler (90f, player.eulerAngles.y, 0f);


	}

}
