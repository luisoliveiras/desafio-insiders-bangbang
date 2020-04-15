using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour
{
    [Range(1,60)]
    public float velocity = 1.0f;
    public float angle = 45f;

    public GameObject ballObject;
    private Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
        GameObject ball = Instantiate(ballObject,transform.position, Quaternion.identity);
        Rigidbody2D ballrigidbody = ball.GetComponent<Rigidbody2D>();
        ballrigidbody.AddForce(dir * velocity, ForceMode2D.Impulse);
    }
}
