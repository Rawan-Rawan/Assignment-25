using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public Vector3 maxScale = new Vector3(1f, 1f, 1f);
    public Vector3 minScale = new Vector3(0f, 0f, 0f);
    public float scaleSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.localScale = Vector3.Lerp(transform.localScale, maxScale, Time.deltaTime * scaleSpeed);
        }
        else if (Input.GetMouseButton(1))
        {
            transform.localScale = Vector3.Lerp(transform.localScale, minScale, Time.deltaTime * scaleSpeed);
        }
    }
}
