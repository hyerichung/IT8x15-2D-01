using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroManager : MonoBehaviour
{
  public enum Transition { Stand, Run, Fall, Jump };

  public bool onGround = false;
  public float jumpForce = 7.0f;
  public int movementSpeed = 10;

  Animator anim;
  Rigidbody2D rb;

  void Awake()
  {
    anim = GetComponent<Animator>();

    rb = GetComponent<Rigidbody2D>();
    rb.freezeRotation = true;
  }

  void Update()
  {
    if (!GameManager.isAlive)
    {
      ChangeAnimation(Transition.Fall);
    }
  }

  void FixedUpdate()
  {
    if (!GameManager.isAlive) return;

    if (Input.GetKeyDown("up"))
    {
      if (onGround)
      {
        rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
      }
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
      rb.velocity = new Vector2(movementSpeed, rb.velocity.y);

      if (onGround)
      {
        ChangeAnimation(Transition.Run);
      }
    }
    else if (Input.GetKey(KeyCode.LeftArrow))
    {
      rb.velocity = new Vector2(movementSpeed * -1, rb.velocity.y);

      if (onGround)
      {
        ChangeAnimation(Transition.Run);
      }
    }
    else if (!Input.anyKey)
    {
      if (onGround)
      {
        ChangeAnimation(Transition.Stand);
      }
    }
  }

  // jumping
  void OnCollisionExit2D(Collision2D collision)
  {
    onGround = false;
    ChangeAnimation(Transition.Jump);
  }

  // landing moment
  void OnCollisionStay2D(Collision2D collision)
  {
    onGround = true;
  }

  // exact landing moment
  void OnCollisionEnter2D(Collision2D collision)
  {
    onGround = true;
  }

  void ChangeAnimation(Transition transition)
  {
    anim.SetInteger("Transition", (int)transition);
  }
}
