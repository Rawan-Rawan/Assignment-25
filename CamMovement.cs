using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CamMovement : MonoBehaviour
{
    float currentZoom = 10f;
    public float minZoom = 10f;
    public float maxZoom = 100f;
    public float zoomSpeed = 50f;
    public float rotationSpeed = 1000f;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        if (mouseScroll != 0)
        {
            currentZoom -= mouseScroll * zoomSpeed;
            currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
            Camera.main.fieldOfView = currentZoom;
        }

        if (Input.GetMouseButton(2))
        {
            float horizontal = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float vertical = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

           
            transform.RotateAround(target.position, Vector3.up, horizontal);
            transform.RotateAround(target.position, transform.right, -vertical);
        }

        transform.LookAt(target);
    }
}
