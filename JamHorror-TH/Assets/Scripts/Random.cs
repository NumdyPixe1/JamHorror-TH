using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace A
{
  public class Random : MonoBehaviour
  {
    public BotRandom botRandom;
    [SerializeField] static private int randomPlayerDice;
    public List<GameObject> dice = new List<GameObject>();
    public GameObject item;
    public GameObject rolling;


    [SerializeField] private bool isCheckResult = false;
    [SerializeField] private bool isWait = false;
    Animator animator;

    void Start()
    {
      animator = GetComponent<Animator>();
      rolling.SetActive(false);
      item.SetActive(false);

      for (int i = 0; i < 3; i++)
      {
        dice[i].SetActive(false);
      }
    }

    public void PickRandom()
    {
      if (isWait == false && isCheckResult == false)
      {
        rolling.SetActive(true);
        item.SetActive(false);

        randomPlayerDice = UnityEngine.Random.Range(0, 3);
        if (randomPlayerDice == 0)//ออกกระดาษ
        {
          Debug.Log(randomPlayerDice);
          dice[2].SetActive(false);
          dice[1].SetActive(true);
          dice[0].SetActive(false);
          Debug.Log("You got paper");

        }
        else if (randomPlayerDice == 1)//ออกค้อน
        {
          Debug.Log(randomPlayerDice);
          dice[2].SetActive(false);
          dice[1].SetActive(false);
          dice[0].SetActive(true);
          Debug.Log("You got rock");

        }
        else if (randomPlayerDice == 2)//ออกกรรไกร
        {
          Debug.Log(randomPlayerDice);
          dice[2].SetActive(true);
          dice[1].SetActive(false);
          dice[0].SetActive(false);
          Debug.Log("You got scissors");

        }
        StartCoroutine(RollingAnimation());
      }
    }
    IEnumerator RollingAnimation()
    {
      isWait = true;
      isCheckResult = true;
      Result();
      yield return new WaitForSeconds(0.5f);
      item.SetActive(true);
      rolling.SetActive(false);
      isWait = false;
      isCheckResult = false;
    }
    public void Result()
    {

      if (isCheckResult == true && isWait == true)
      {
        // Debug.Log(randomPlayerDice + " & " + botRandom.randomBotDice);
        if (randomPlayerDice == 0 && botRandom.randomBotDice == 0) { Debug.Log("It's a tie!, You and bot selected paper" + randomPlayerDice + " & " + botRandom.randomBotDice); }
        else if (randomPlayerDice == 0 && botRandom.randomBotDice == 1) { Debug.Log("You win!, Paper cover rock" + randomPlayerDice + " & " + botRandom.randomBotDice); }
        else if (randomPlayerDice == 0 && botRandom.randomBotDice == 2) { Debug.Log("You lose!, Scissors cut paper" + randomPlayerDice + " & " + botRandom.randomBotDice); }

        else if (randomPlayerDice == 1 && botRandom.randomBotDice == 0) { Debug.Log("You lose! Paper cover rock" + randomPlayerDice + " & " + botRandom.randomBotDice); }
        else if (randomPlayerDice == 1 && botRandom.randomBotDice == 1) { Debug.Log("It's a tie!, You and bot selected rock" + randomPlayerDice + " & " + botRandom.randomBotDice); }
        else if (randomPlayerDice == 1 && botRandom.randomBotDice == 2) { Debug.Log("You win!, Rock smashes scissors" + randomPlayerDice + " & " + botRandom.randomBotDice); }

        else if (randomPlayerDice == 2 && botRandom.randomBotDice == 0) { Debug.Log("You lose!, Scissors cut paper" + randomPlayerDice + " & " + botRandom.randomBotDice); }
        else if (randomPlayerDice == 2 && botRandom.randomBotDice == 1) { Debug.Log("You win!, Rock smashes scissors" + randomPlayerDice + " & " + botRandom.randomBotDice); }
        else if (randomPlayerDice == 2 && botRandom.randomBotDice == 2) { Debug.Log("It's a tie!, You and bot selected scissors" + randomPlayerDice + " & " + botRandom.randomBotDice); }
      }
    }


    void Update()
    {

    }
  }
}

