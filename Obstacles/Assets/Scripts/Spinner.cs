using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValue = 100f;
    [SerializeField] float zValue = 0f;

    // Update is called once per frame
    void Update()
    {
        var rotation = new Vector3(xValue, yValue, zValue);
        transform.Rotate(rotation * Time.deltaTime);
    }
}
