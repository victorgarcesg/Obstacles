using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public YouWinScreen YouWinScreen;
    private void OnCollisionEnter(Collision collision)
    {
        YouWinScreen.Setup();
    }
}
