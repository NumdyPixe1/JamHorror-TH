using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotRandom : MonoBehaviour
{
    public bool isWait = false;
    Animator animator;
    public GameObject item;
    public GameObject rolling;

    public int randomBotDice;

    public List<GameObject> diceBot = new List<GameObject>();
    void Start()
    {
        animator = GetComponent<Animator>();
        rolling.SetActive(false);
        item.SetActive(false);

        for (int i = 0; i < 3; i++)
        {
            diceBot[i].SetActive(false);
        }
    }
    public void BotRandomDice()
    {
        // animator.SetTrigger("Rolling");

        if (isWait == false)
        {
            rolling.SetActive(true);
            item.SetActive(false);

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
            StartCoroutine(RollingAnimation());

        }
        IEnumerator RollingAnimation()
        {
            isWait = true;
            yield return new WaitForSeconds(0.5f);
            item.SetActive(true);
            rolling.SetActive(false);
            isWait = false;
        }

    }
}