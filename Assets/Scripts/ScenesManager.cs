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

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

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
