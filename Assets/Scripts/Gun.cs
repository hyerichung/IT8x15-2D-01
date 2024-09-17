using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gun : MonoBehaviour
{
  public enum State { Stand, Charge, Fire };

  public GameObject gun;
  public UnityEvent OnTrigger;

  public AudioManager audioManager;

  Animator anim;
  private int currentState;

  private void Awake()
  {
    audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

    anim = GetComponent<Animator>();
    currentState = 0;
  }

  private void Update()
  {
    if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
    {
      currentState++;

      if (currentState == 3)
      {
        currentState = 0;
      }

      anim.SetInteger("State", currentState);

    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    OnTrigger.Invoke();

    audioManager.PlaySFX(audioManager.electronic1);
  }
}

