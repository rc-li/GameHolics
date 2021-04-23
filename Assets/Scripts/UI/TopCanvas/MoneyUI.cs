using UnityEngine;
using UnityEngine.UI;

public class MoneyUI : MonoBehaviour
{
    private Text moneyText;

    private void Start()
    {
        moneyText = GetComponentInChildren<Text>();
        moneyText.text = "0";
    }

    private void Update()
    {
        moneyText.text = PlayerStatus.money.ToString();
    }
}
