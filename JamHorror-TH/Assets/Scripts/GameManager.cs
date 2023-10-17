using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  [SerializeField] private static GameManager instance;

  public void ButtonStart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }


  private void Update()
  {

  }




}
