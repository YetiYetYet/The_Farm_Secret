using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderLog : MonoBehaviour
{
    public bool EnableLog = true;
    private void OnTriggerEnter(Collider other)
    {
        if (EnableLog)
        {
            var parent = transform.parent.name;
            if (parent == "")
                parent = transform.name;
            Debug.Log(other.name + " collide with " + parent);
        } 
    }
}
