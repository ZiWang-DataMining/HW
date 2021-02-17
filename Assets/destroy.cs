using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("fish"))
        {
            Destroy(other.gameObject);
        }
    }
}
