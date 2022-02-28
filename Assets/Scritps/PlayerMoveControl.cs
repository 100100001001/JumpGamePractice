using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerMoveControl : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = h * Vector3.right + v * Vector3.up;

        this.transform.Translate(dir * speed * Time.deltaTime);
    }
}
