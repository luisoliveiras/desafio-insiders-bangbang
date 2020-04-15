using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindComponent : MonoBehaviour
{
    public float force;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Physics2D.gravity = new Vector2(force, Physics2D.gravity.y);
        }
    }

}
