using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gun : MonoBehaviour
{
  public GameObject gun;
  public UnityEvent OnTrigger;

  public AudioManager audioManager;

  private void Awake()
  {
    audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    OnTrigger.Invoke();

    audioManager.PlaySFX(audioManager.electronic1);
  }
}

