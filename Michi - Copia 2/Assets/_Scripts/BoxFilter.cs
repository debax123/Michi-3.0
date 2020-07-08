using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFilter : MonoBehaviour
{
    public Collider col1;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Physics.IgnoreCollision(collision.collider, col1);
        }
    }
}
