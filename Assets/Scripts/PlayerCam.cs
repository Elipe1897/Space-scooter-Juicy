using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

	public Transform target;
	public float distance = 10.0f;

	void LateUpdate()
	{
		transform.position = target.position + new Vector3(0, 4, -distance);
	}
}