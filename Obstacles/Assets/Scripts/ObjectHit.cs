 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            collision.gameObject.transform.localPosition = new Vector3(-15.89f, 0.194f, -15.95f);
        }
    }
}
