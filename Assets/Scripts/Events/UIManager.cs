using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance = null;
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private TextMeshProUGUI earningPrizeText;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        CoinManagerwithEvent.EarnMoneyEvent += UpdateCoinText;
    }
    private void UpdateCoinText()
    {
        coinText.text = CoinManagerwithEvent.instance.coin.ToString();
    }
    public void UpdatePrizeText()
    {
        earningPrizeText.text = "Earn " + CoinManagerwithEvent.instance.earningPrize + " Coin";
    }
   
}
