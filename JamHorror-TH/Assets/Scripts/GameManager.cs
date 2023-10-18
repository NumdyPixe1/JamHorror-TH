using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
  // public GameObject rollButton, restartButton;
  // [SerializeField] private Random random;
  [SerializeField] private static GameManager instance;
  private void Awake()
  {
    // restartButton.SetActive(false);


    // random = GetComponent<Random>();
    // textRestrat.text = " ";
  }
  public void ButtonStart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    Destroy(this);
    // rollButton.SetActive(true);

  }
  public void Restart()
  {
    StartCoroutine(DelaySceneLoad());
  }
  IEnumerator DelaySceneLoad()
  {
    yield return new WaitForSeconds(0.1f);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
  private void Update()
  {
    // if (random.playerHp == 0 || random.botRandom.botHp == 0)
    // {
    //   textRestrat.text = "RESTART";
    //   restartButton.SetActive(true);
    //   rollButton.SetActive(false);
    // }
    // if (SceneManager.GetActiveScene().buildIndex == 1)
    // {

    // }

  }







}
