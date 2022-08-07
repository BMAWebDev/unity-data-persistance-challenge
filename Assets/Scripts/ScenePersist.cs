using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScenePersist : MonoBehaviour
{
  public static string playerName;

  public TMP_InputField inputField;

  void Awake()
  {
    DontDestroyOnLoad(gameObject);
  }

  public void UpdateName()
  {
    playerName = inputField.GetComponent<TMP_InputField>().text;
  }
}
