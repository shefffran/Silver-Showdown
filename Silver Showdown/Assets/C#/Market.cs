using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    [SerializeField] GameObject[] Hp;
    public CoinSystem coinSystem;
    [SerializeField] private GameObject Hp_Saled;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int i_Hp = 0;
    public void HP_buy()
    {
        if (coinSystem.Coin > 0)
        {
            Hp[i_Hp].gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            i_Hp++;
            coinSystem.Coin--;
        }

        if(i_Hp == Hp.Length)
        {
            this.gameObject.SetActive(false);
            Hp_Saled.SetActive(false);
        }

    }
}
