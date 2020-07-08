using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFilter : MonoBehaviour
{
    public Collider col1;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Pushable")
        {
            Physics.IgnoreCollision(collision.collider, col1);
        }
        if (collision.gameObject.tag == "Rocks")
        {
            Physics.IgnoreCollision(collision.collider, col1);
        }
    }
}
