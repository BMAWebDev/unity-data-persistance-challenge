using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{
  public void StartGame()
  {
    SceneManager.LoadScene(1);
  }

  public void Exit()
  {
#if UNITY_EDITOR
    EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif
  }
}
