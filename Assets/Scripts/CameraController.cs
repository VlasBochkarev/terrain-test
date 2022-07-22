using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;

    private float _mouseX;
    private float _mouseY;
    private float _sensitivityMose = 200f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        MouseManager();
    }

    private void MouseManager()
	{
        _mouseX = Input.GetAxis("Mouse X") * _sensitivityMose * Time.deltaTime;
        _mouseY = Input.GetAxis("Mouse Y") * _sensitivityMose * Time.deltaTime;

        Player.Rotate(_mouseX * new Vector3(0, 1, 0));

        transform.Rotate(-_mouseY * new Vector3(1, 0, 0)); 
	}
}
