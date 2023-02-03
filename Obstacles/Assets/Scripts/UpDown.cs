using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    [SerializeField] [Range(0, 1)] float speed = 0.2f;
    [SerializeField] [Range(0, 100)] float range = 5f;
    private float initalYValue;

    void Start()
    {
        initalYValue = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 1) * range;
        transform.position = new Vector3(transform.position.x, y + initalYValue, transform.position.z);
        Debug.Log(transform.position);
    }
}
