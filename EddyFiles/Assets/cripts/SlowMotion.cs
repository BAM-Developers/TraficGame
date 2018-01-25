using UnityEngine;

public class SlowMotion : MonoBehaviour {
	public float slowtime=0.5f;

	public void DoslowTime()
	{
		Time.timeScale = slowtime;
		Time.fixedDeltaTime = Time.timeScale * 0.02f;
	}



}
