using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatingCharacters : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 currentPosition = transform.position;
            float newZ = currentPosition.z + 0.001f;
            transform.position = new Vector3(currentPosition.x, currentPosition.y, newZ);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 currentPosition = transform.position;
            float newZ = currentPosition.z - 0.001f;
            transform.position = new Vector3(currentPosition.x, currentPosition.y, newZ);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 currentPosition = transform.position;
            float newX = currentPosition.x + 0.001f;
            transform.position = new Vector3(newX, currentPosition.y, currentPosition.z);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 currentPosition = transform.position;
            float newX = currentPosition.x - 0.001f;
            transform.position = new Vector3(newX, currentPosition.y, currentPosition.z);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            Vector3 currentPosition = transform.position;
            float newY = currentPosition.y + 0.001f;
            transform.position = new Vector3(currentPosition.x, newY, currentPosition.z);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Vector3 currentPosition = transform.position;
            float newY = currentPosition.y- 0.001f;
            transform.position = new Vector3(currentPosition.x, newY, currentPosition.z);
        }
    }
}
