using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public static float hp;
  public static bool isAlive;

  public GameObject GameOverUI;
  public AudioManager audioManager;

  void Awake()
  {
    audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

    isAlive = true;
    hp = 100f;
  }

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
    if (isAlive)
    {
      audioManager.PlaySFX(audioManager.over);
    }

    isAlive = false;
    GameOverUI.SetActive(true);
  }

  public void Restart()
  {
    isAlive = true;
    hp = 100f;

    GameOverUI.SetActive(false);
  }

  public void IncreaseHp(float health)
  {
    float addedHp = hp += health;

    if (addedHp >= 100f)
    {
      hp = 100f;
    }
    else
    {
      hp = addedHp;
    };
  }

  public void DecreaseHp(float health)
  {
    float decreasedHp = hp -= health;

    if (decreasedHp <= 0)
    {
      hp = 0;
    }
    else
    {
      hp = decreasedHp;
    }
  }

}
