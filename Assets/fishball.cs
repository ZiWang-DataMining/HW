using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishball : MonoBehaviour
{
    public GameObject ball;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(ball, new Vector3(cursorPos.x, cursorPos.y, cursorPos.z), Quaternion.identity);
        }
    }
}
