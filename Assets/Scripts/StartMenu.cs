using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
  [SerializeField] Button startButton;

  // Start is called before the first frame update
  void Start()
  {
    startButton.onClick.AddListener(StartNewGame);
  }

  void StartNewGame()
  {
    Debug.Log("???");
    ScenesManager.Instance.LoadScene(ScenesManager.Scene.Main);
  }
}
