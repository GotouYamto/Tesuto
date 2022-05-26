using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float bounce = 10f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            collision.rigidbody.AddForce(0f, bounce , bounce * 2, ForceMode.Impulse);
        }
    }
}
