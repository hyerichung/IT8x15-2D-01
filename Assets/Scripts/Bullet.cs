using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
  public GameObject bullet;
  public UnityEvent OnTrigger;

  public AudioManager audioManager;

  private void OnTriggerEnter2D(Collider2D collision)
  {
    OnTrigger.Invoke();

    audioManager.PlaySFX(audioManager.electronic1);
  }
}
