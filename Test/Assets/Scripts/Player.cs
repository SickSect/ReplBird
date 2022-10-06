using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody2D rigidBody;
    public RotateAnimation rotateAnimation;

    private void Update()
    { 
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            rigidBody.velocity = new Vector2();
            rigidBody.AddForce((Vector2)(transform.up * jumpForce), ForceMode2D.Impulse);
            rotateAnimation.StartRotation();
        }
        rotateAnimation.ApplyRotation(rigidBody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PipePart"))
        {
            GameManager.instance.Lose();
        }
    }
}
