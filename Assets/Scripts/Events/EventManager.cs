using System;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{

    [Serializable] public class OnSpacePressed : UnityEvent { }

    public OnSpacePressed spacePressedEvent;

    private void Start()
    {
        spacePressedEvent.AddListener(CoinManagerwithEvent.instance.EarnMoneyButton);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressedEvent?.Invoke();
        }
    }
}
