using UnityEngine;
using TMPro;

public class CoinController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private TextMeshProUGUI earningPrizeText;
    private int _coin = 0;
    private int _earningPrize = 50;

    private delegate void EarnMoneyDelegate();
    EarnMoneyDelegate earnMoneyDelegate;

    private delegate int ChangePrize(int x);
    ChangePrize changePrize;

    private void Start()
    {
        earnMoneyDelegate += Earn50Coin;
        earnMoneyDelegate += UpdateCoinText;
    }

    public void EarnMoneyButton()
    {
        earnMoneyDelegate();
    }

    public void AddCointoPrizeButton()
    {
        changePrize = null;
        changePrize += AddCoinfromPrize;
        changePrize(10);
        UpdatePrizeText();
    }
    public void SubractCointoPrizeButton()
    {
        changePrize = null;
        changePrize += SubractCoinfromPrize;
        changePrize(10);
        UpdatePrizeText();
    }
    private void Earn50Coin()
    {
        _coin += _earningPrize;
    }

    private void UpdateCoinText()
    {
        coinText.text = _coin.ToString();
    }

    private int AddCoinfromPrize(int extraPrize)
    {
       return _earningPrize += extraPrize;
    }

    private int SubractCoinfromPrize(int extraPrize)
    {
       return _earningPrize -= extraPrize;
    }

    private void UpdatePrizeText()
    {
        earningPrizeText.text = "Earn " + _earningPrize + " Coin";
    }
}
