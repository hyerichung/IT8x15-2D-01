using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GunLight : MonoBehaviour
{
  public GameObject gunLight;
  public UnityEvent OnTrigger;

  private void OnTriggerEnter2D(Collider2D collision)
  {
    OnTrigger.Invoke();
  }
}
