using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject cube;
    Vector3 targetPosition;

    void Start()
    {

        targetPosition = transform.position;
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                targetPosition = hit.point;
                cube.transform.position = targetPosition;
            }
        }
    }
}
