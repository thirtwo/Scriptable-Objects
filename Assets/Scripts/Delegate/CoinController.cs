using UnityEngine;
using TMPro;

public class CoinController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    private int _coin = 0;

    private delegate void EarnMoneyDelegate();
    EarnMoneyDelegate earnMoneyDelegate;

    private void Start()
    {
        earnMoneyDelegate += Earn50Coin;
        earnMoneyDelegate += UpdateCoinText;
    }

    public void EarnMoneyButton()
    {
        earnMoneyDelegate();
    }

    private void Earn50Coin()
    {
        _coin += 50;
    }

    private void UpdateCoinText()
    {
        coinText.text = _coin.ToString();
    }
}
