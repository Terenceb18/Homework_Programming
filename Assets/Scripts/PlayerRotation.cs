using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private Camera _camera;
    private string CameraName = "Game_Camera";
    private Vector3 _positionMouse;


    private void Start()
    {
        _camera = GameObject.Find(CameraName).GetComponent<Camera>();
    }

    private void Update()
    {
        _positionMouse = _camera.ScreenToWorldPoint(Input.mousePosition);

    }



}


