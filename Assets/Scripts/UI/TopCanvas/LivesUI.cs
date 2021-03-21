using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    private Text livesText;

    private void Start()
    {
        livesText = GetComponentInChildren<Text>();
        livesText.text = "0";

    }

    private void Update()
    {
        livesText.text = PlayerStatus.lives.ToString();
    }
}
