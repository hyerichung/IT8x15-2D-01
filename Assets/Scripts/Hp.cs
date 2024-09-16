using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{
  public Text uiText;
  public UnityEvent OnGameOver;

  void Start()
  {
    uiText = GetComponent<Text>();
  }

  void Update()
  {
    uiText.text = GameManager.hp.ToString("F0");

    if (GameManager.hp == 0)
    {
      OnGameOver.Invoke();
    }
  }
}
