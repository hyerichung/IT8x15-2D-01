using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Laser : MonoBehaviour
{
  public GameObject laser;
  public UnityEvent OnTrigger;

  public AudioManager audioManager;

  private void Awake()
  {
    audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    OnTrigger.Invoke();

    audioManager.PlaySFX(audioManager.electronic2);
  }
}
