using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static float hp;
  public static bool isAlive;

  public GameObject OverUI;

  void Awake()
  {
    isAlive = true;
    hp = 100f;
  }

  // Start is called before the first frame update
  void Start()
  {
    if (!isAlive) return;
  }

  void Update()
  {
    Debug.Log(hp);
  }

  public void GameOver()
  {
    isAlive = false;
    OverUI.SetActive(true);
  }

  public void Restart()
  {
    isAlive = true;
    hp = 100f;
  }

  public void IncreaseHp(float health)
  {
    if (hp >= 100f) return;

    hp += health;
  }

  public void DecreaseHp(float health)
  {
    if (hp <= 0) return;

    hp -= health;
  }

}
