using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace A
{
  public class Random : MonoBehaviour
  {
    public BotRandom botRandom;
    [SerializeField] private int randomDice;
    // [SerializeField] private Sprite[] sprite;
    public List<GameObject> dice = new List<GameObject>();


    // [SerializeField] private SpriteRenderer spriteRenderer;
    void Start()
    {
      for (int i = 0; i < 3; i++)
      {
        dice[i].SetActive(false);
      }
      // spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void PickRandom()
    {
      // for (int i = 0; i < 3; i++)

      randomDice = UnityEngine.Random.Range(0, 3);

      if (randomDice == 0)
      {
        dice[2].SetActive(false);
        dice[1].SetActive(true);
        dice[0].SetActive(false);
        Debug.Log("You got paper");

      }
      else if (randomDice == 1)
      {
        dice[2].SetActive(false);
        dice[1].SetActive(false);
        dice[0].SetActive(true);
        Debug.Log("You got rock");
      }
      else if (randomDice == 2)
      {
        dice[2].SetActive(true);
        dice[1].SetActive(false);
        dice[0].SetActive(false);
        Debug.Log("You got scissors");
      }
    }
    private void Result()
    {
      if (randomDice == 1)
      {
        Debug.Log("You got paper");

      }
      // if (botRandom.randomBotDice == randomDice)
      // {

      // }
    }

    void Update()
    {







    }







  }
}