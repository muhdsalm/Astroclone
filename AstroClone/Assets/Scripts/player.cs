using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed;
    public bool isrotating = false;
    public Rigidbody2D player_rb;
    
    // Update is called once per frame
    void Update()
    {
        player_rb.AddForce(Vector2.right * speed * Time.deltaTime);
    }
}
