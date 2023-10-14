using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotRandom : MonoBehaviour
{
    public int randomBotDice;
    public List<GameObject> diceBot = new List<GameObject>();
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            diceBot[i].SetActive(false);
        }
    }
    public void BotRandomDice()
    {
        randomBotDice = UnityEngine.Random.Range(0, 3);

        if (randomBotDice == 0)
        {
            if (randomBotDice == 0)
            {
                diceBot[2].SetActive(false);
                diceBot[1].SetActive(true);
                diceBot[0].SetActive(false);
                Debug.Log("Bot got paper");
            }
        }
        else if (randomBotDice == 1)
        {
            if (randomBotDice == 1)
            {
                diceBot[2].SetActive(false);
                diceBot[1].SetActive(false);
                diceBot[0].SetActive(true);
                Debug.Log("Bot got rock");
            }

        }
        else if (randomBotDice == 2)
        {
            if (randomBotDice == 2)
            {
                diceBot[2].SetActive(true);
                diceBot[1].SetActive(false);
                diceBot[0].SetActive(false);
                Debug.Log("Bot got scissors");
            }
        }


    }


}
