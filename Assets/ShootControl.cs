using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour
{
    public float velocity = 1.0f;
    public float angle = 45f;

    public GameObject ball;
    private Rigidbody2D ball_rb;
    private Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        ball_rb = ball.GetComponent<Rigidbody2D>();
        ball.transform.position = new Vector3(0.0f, -2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
        ball_rb.AddForce(dir * velocity);
    }
}
