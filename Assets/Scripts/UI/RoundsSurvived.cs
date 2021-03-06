using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundsSurvived : MonoBehaviour
{
    public Text rounds;

    void OnEnable()
    {
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        rounds.text = "0";
        int round = 0;

        yield return new WaitForSeconds(1.0f);

        while (round < PlayerStatus.Rounds)
        {
            round++;
            rounds.text = round.ToString();

            yield return new WaitForSeconds(.05f);
        }
    }
}

