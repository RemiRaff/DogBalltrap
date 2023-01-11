using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // Destroy dog
        // Destroy(other.gameObject);

        // Destroy ball
        Destroy(gameObject);
    }
}
