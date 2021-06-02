using UnityEngine;

public class CoinManagerwithEvent : MonoBehaviour
{
    public static CoinManagerwithEvent instance = null; // Basic singleton
    public  int coin = 0;
    public  int earningPrize = 50;

    public delegate void EarnMoneyDelegate(); // we need delegates for events
    public static event EarnMoneyDelegate EarnMoneyEvent; // Creating events
    public delegate void ChangePrize();
    public static event ChangePrize ChangePrizeEvent;

    private void Awake()
    {
        instance = this;
        EarnMoneyEvent += Earn50Coin; // registering with an event
    }


    private void Earn50Coin()
    {
        coin += earningPrize;
    }

    private void Add10CointoPrize()
    {
        earningPrize += 10;
    }

    private void Subract10CoinfromPrize()
    {
        earningPrize -= 10;
    }

    public void EarnMoneyButton()
    {
        EarnMoneyEvent?.Invoke(); // Starting EarnMoneyEvent if not null
    }

    public void AddCointoPrizeButton()
    {
        ChangePrizeEvent = null;
        ChangePrizeEvent += Add10CointoPrize;
        ChangePrizeEvent += UIManager.instance.UpdatePrizeText;
        ChangePrizeEvent?.Invoke();
    }

    public void SubractCointoPrizeButton()
    {
        ChangePrizeEvent = null;
        ChangePrizeEvent += Subract10CoinfromPrize;
        ChangePrizeEvent += UIManager.instance.UpdatePrizeText;
        ChangePrizeEvent?.Invoke();
    }
}


