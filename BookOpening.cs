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


        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10;
            Vector3 inunityPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            mousePosition.x = Mathf.Clamp(mousePosition.x, 0f, Screen.width);
            float targetAngle = Mathf.Lerp(0, 180, mousePosition.x / Screen.width);
            float angle = Mathf.Lerp(transform.rotation.eulerAngles.z, targetAngle, Time.deltaTime * 1f);

            transform.rotation = Quaternion.Euler(0, 0, angle);
        }

      


    }
}
