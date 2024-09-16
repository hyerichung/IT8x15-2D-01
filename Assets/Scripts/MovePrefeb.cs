using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePrefab : MonoBehaviour
{
  public GameObject prefabToMove;
  public GameObject currentPrefab;
  public float incrementX;

  //belongs to prefab to move
  public GameObject fuelCanOnNextPrefeb;
  public GameObject laserOnNextPrefeb;

  // Use this for initialization
  void Start()
  {

  }

  void OnTriggerEnter2D()
  {
    Vector3 temp = currentPrefab.transform.position;

    temp.x = temp.x + incrementX;

    prefabToMove.transform.position = temp;

    // next prefeb에서 랜더마이징 하기
    int choice = Random.Range(0, 2);

    if (choice == 0)
    {
      fuelCanOnNextPrefeb.SetActive(true); laserOnNextPrefeb.SetActive(false);
    }
    else if (choice == 1)
    {
      fuelCanOnNextPrefeb.SetActive(false); laserOnNextPrefeb.SetActive(true);
    }
  }
  // Update is called once per frame
  void Update()
  {

  }

}
