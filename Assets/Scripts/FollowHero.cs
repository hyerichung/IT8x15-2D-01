using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHero : MonoBehaviour
{
  public GameObject heroCopy;
  public float smoothSpeed = 0.1f;

  void Update()
  {
    Vector3 targetPosition = new Vector3(heroCopy.transform.position.x + 7, transform.position.y, transform.position.z);
    Vector3 transformPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);

    transform.position = transformPosition;
  }
}
