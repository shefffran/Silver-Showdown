using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinSystem : MonoBehaviour
{
    public int Coin;
    [SerializeField] TextMeshProUGUI Coin_Text;

    private void Start()
    {
        
    }

    private void Update()
    {
        Coin_Text.text = Coin.ToString();
    }
}
