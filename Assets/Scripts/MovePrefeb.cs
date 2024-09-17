using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrefab : MonoBehaviour
{
  public GameObject prefabToMove;
  public GameObject currentPrefab;
  public float incrementX;


  // todo: next가 아니라 현재 prefeb이 아니고 움직이려고 하는 prefeb이 아닌 prefeb의 object를 미리 결정해놓는 용도임
  // 변수명은 next가 아니라 제 3의 변수명으로 변경되어야함
  public GameObject gunLightOnNextPrefeb;
  public GameObject crateOnNextPrefeb;
  public GameObject fuelCanOnNextPrefeb;
  public GameObject laserOnNextPrefeb;
  public GameObject gunOnNextPrefeb;

  void OnTriggerEnter2D()
  {
    Vector3 temp = currentPrefab.transform.position;
    temp.x = temp.x + incrementX;

    prefabToMove.transform.position = temp;

    /// decide next prefeb's gameObject active status
    GameObject[] objects = new GameObject[5]
    {
    gunLightOnNextPrefeb,
    crateOnNextPrefeb,
    fuelCanOnNextPrefeb,
    laserOnNextPrefeb,
    gunOnNextPrefeb
    };

    for (int i = 0; i < objects.Length; i++)
    {
      int activeChoice = Random.Range(0, 2);
      bool isActive = activeChoice == 0;

      objects[i].SetActive(isActive);
    }
  }
}
