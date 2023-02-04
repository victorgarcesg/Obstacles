using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackForth : MonoBehaviour
{
    [SerializeField] [Range(0, 1)] float speed = 0.2f;
    [SerializeField] [Range(0, 100)] float range = 30f;
    [SerializeField] bool reverse = false;
    private float initalXValue;
    private float direction;

    void Start()
    {
        initalXValue = transform.position.x;
        direction = reverse ? -1 : 1;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, 1) * range;
        transform.position = new Vector3(initalXValue + x * direction, transform.position.y, transform.position.z);
    }
}
