using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistoricalMap1 : MonoBehaviour
{private Vector3 previousMousePosition;
    public Vector3 maxScale = new Vector3(.14f, 0.06f, .16f);
    public Vector3 minScale = new Vector3(0f, 0f, 0f);
    public float scaleSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
previousMousePosition = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 currentMousePosition = Input.mousePosition;
            float deltaX = currentMousePosition.x - previousMousePosition.x;
            if (deltaX > 0)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, maxScale, Time.deltaTime * scaleSpeed);
            }
            else if (deltaX < 0)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, minScale, Time.deltaTime * scaleSpeed);
            }
            previousMousePosition = currentMousePosition;

        }
    }
}
