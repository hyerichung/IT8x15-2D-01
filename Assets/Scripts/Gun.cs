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
  int currentAnimState;

  void Awake()
  {
    audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

    anim = GetComponent<Animator>();
    currentAnimState = 0;
  }

  void Update()
  {
    if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
    {
      currentAnimState++;

      if (currentAnimState == 3)
      {
        currentAnimState = 0;
      }

      anim.SetInteger("State", currentAnimState);

    }
  }

  void OnTriggerEnter2D(Collider2D collision)
  {
    OnTrigger.Invoke();

    audioManager.PlaySFX(audioManager.electronic1);
  }
}

