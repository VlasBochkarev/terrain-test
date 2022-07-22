using UnityEngine;

public class PlayrController : MonoBehaviour
{
	private float _speed = 5;
	

	void Update()
	{
		MoveController();
	}

	private void MoveController()
	{
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward * _speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.back * _speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left * _speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right * _speed * Time.deltaTime);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			transform.Translate(Vector3.up * _speed * 3 * Time.deltaTime);
		}
		
	}
}
