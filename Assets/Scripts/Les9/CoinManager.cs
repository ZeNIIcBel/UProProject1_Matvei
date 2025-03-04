using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : Singleton<CoinManager>
{
    private int coin;
    public int Coin
    {
        get => coin;
        set => coin += value;
    }
}

