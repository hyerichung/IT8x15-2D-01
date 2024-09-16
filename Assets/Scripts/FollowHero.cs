using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHero : MonoBehaviour
{
  public GameObject heroCopy;
  public float smoothSpeed = 0.1f;

  public Vector3 initialPosition;

  void Awake()
  {
    initialPosition = transform.position;
  }

  void Update()
  {
    Vector3 targetPosition = new Vector3(heroCopy.transform.position.x + 7, transform.position.y, transform.position.z);
    Vector3 transformPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);

    bool isExceed = transform.position.x - initialPosition.x < 0;

    bool isTransformable = heroCopy.transform.position.x > transform.position.x || heroCopy.transform.position.x < transform.position.x && !isExceed;

    if (isTransformable)
    {
      transform.position = transformPosition;
    }
  }

}
