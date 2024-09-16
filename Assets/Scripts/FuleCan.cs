using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FuleCan : MonoBehaviour
{
  public GameObject fuelCan;

  public UnityEvent OnTrigger;
  public AudioManager audioManager;

  private void Awake()
  {
    audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    fuelCan.SetActive(false);

    OnTrigger.Invoke();

    audioManager.PlaySFX(audioManager.heal);
  }
}
