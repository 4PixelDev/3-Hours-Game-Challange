using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [SerializeField] private float playerMoveSpeed = 5f;
    private Rigidbody2D rb;

    float horizontalMovement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalMovement * playerMoveSpeed, rb.velocity.y);
    }
}
