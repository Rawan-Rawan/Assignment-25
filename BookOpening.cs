using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookOpening : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 inunityPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (Input.GetMouseButton(0))
        {
            mousePosition.x = Mathf.Clamp(mousePosition.x, 0f, 180f);
            float targetAngle = Mathf.Lerp(0, 180, mousePosition.x / 180f);


            float angle = Mathf.Lerp(transform.rotation.eulerAngles.z, targetAngle, Time.deltaTime * 1f);


            transform.rotation = Quaternion.Euler(0, 0, angle);
        }

        else if (Input.GetMouseButton(1))
        {

            float targetAngle = 0f;

            float angle = Mathf.Lerp(transform.rotation.eulerAngles.z, targetAngle, Time.deltaTime * 1f);


            transform.rotation = Quaternion.Euler(0, 0, angle);
        }


    }
}
