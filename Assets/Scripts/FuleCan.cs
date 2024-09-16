using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FuleCan : MonoBehaviour
{
  public GameObject fuelCan;

  public UnityEvent OnTrigger;


  private void OnTriggerEnter2D(Collider2D collision)
  {
    fuelCan.SetActive(false);

    OnTrigger.Invoke();
  }
}
