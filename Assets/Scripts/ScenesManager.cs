using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
  public static ScenesManager Instance;

  void Awake()
  {
    Instance = this;
  }

  public enum Scene
  {
    Start,
    Main
  }

  public void LoadScene(Scene scene)
  {
    SceneManager.LoadScene(scene.ToString());
  }

  public void LoadMainScene()
  {
    SceneManager.LoadScene(Scene.Main.ToString());
  }

  public void LoadStartScene()
  {
    SceneManager.LoadScene(Scene.Start.ToString());
  }
}
