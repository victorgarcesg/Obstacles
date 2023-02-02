using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit"))
        {
            score++;
            collision.gameObject.tag = "Hit";
            Debug.Log($"You've bumped this many things: {score}");
        }
    }
}
