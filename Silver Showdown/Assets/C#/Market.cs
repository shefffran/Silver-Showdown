using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    public CoinSystem coinSystem;

    [Header("HP")]
    [SerializeField] GameObject[] Hp;
    [SerializeField] private GameObject Hp_Saled;
    [SerializeField] private GameObject Hp_Buy;


    [Header("Shield")]
    [SerializeField] GameObject[] Shield;
    [SerializeField] private GameObject Shield_Saled;
    [SerializeField] private GameObject Shield_Buy;


    [Header("Gun")]
    [SerializeField] GameObject[] Gun;
    [SerializeField] private GameObject Gun_Saled;
    [SerializeField] private GameObject Gun_Buy;

    int i_Hp = 0;
    public void HP_buy()
    {
        if (coinSystem.Coin > 0)
        {
            Hp[i_Hp].gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            i_Hp++;
            coinSystem.Coin--;
        }

        if (i_Hp == Hp.Length)
        {
            Hp_Buy.SetActive(false);
            Hp_Saled.SetActive(true);
        }

    }

    int i_Shield = 0;
    public void Shield_buy()
    {
        if (coinSystem.Coin > 0)
        {
            Shield[i_Shield].gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            i_Shield++;
            coinSystem.Coin--;
        }

        if(i_Shield == Shield.Length)
        {
            Shield_Buy.SetActive(false);
            Shield_Saled.SetActive(true);
        }

    }


    int i_Gun = 0;
    public void Gun_buy()
    {
        if (coinSystem.Coin > 0)
        {
            Gun[i_Gun].gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            i_Gun++;
            coinSystem.Coin--;
        }

        if (i_Gun == Gun.Length)
        {
            Gun_Buy.SetActive(false);
            Gun_Saled.SetActive(true);
        }

    }


}
