using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrefab : MonoBehaviour
{
  public GameObject prefabToMove;
  public GameObject currentPrefab;
  public float incrementX;

  public GameObject gunLightToBeRandom;
  public GameObject crateToBeRandom;
  public GameObject fuelCanToBeRandom;
  public GameObject laserToBeRandom;
  public GameObject gunToBeRandom;

  void OnTriggerEnter2D()
  {
    Vector3 temp = currentPrefab.transform.position;
    temp.x = temp.x + incrementX;

    prefabToMove.transform.position = temp;

    GameObject[] objects = new GameObject[5]
    {
    gunLightToBeRandom,
    crateToBeRandom,
    fuelCanToBeRandom,
    laserToBeRandom,
    gunToBeRandom
    };

    for (int i = 0; i < objects.Length; i++)
    {
      int activeChoice = Random.Range(0, 2);
      bool isActive = activeChoice == 0;

      objects[i].SetActive(isActive);
    }
  }
}
