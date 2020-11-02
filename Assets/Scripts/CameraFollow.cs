using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	private Transform target;
	public float offset ;

	void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}


	void LateUpdate ()
	{
		Vector3 temp = transform.position;

		temp.x = target.position.x;
		temp.y = target.position.y;

		temp.x += offset;
		temp.y += offset;

		transform.position = temp; 
	}

}
