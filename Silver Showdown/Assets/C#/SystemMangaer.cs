using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SystemMangaer : MonoBehaviour
{
    public bool HorT = false;
    public bool BooleanHorT;
    public Animator anim;
    
    [Header("Coin Header Anim")]

    [SerializeField] private GameObject HeaderText;
    [SerializeField] private GameObject coinAnimationHeader;


    [Header("Coin Header Tails")]

    [SerializeField] private GameObject TailsText;
    [SerializeField] private GameObject coinAnimationTails;



    public void ChosingHorT()
    {
        BooleanHorT = (Random.value > 0.5f);
        if(HorT != BooleanHorT)
        {
            Lose();
        }
        else if(HorT == true && BooleanHorT == true)
        {
            StartCoroutine("startAnimationHeader");
        }
        else if (HorT == false && BooleanHorT == false)
        {
            startAnimationTail();
        }
    }


    private void Lose()
    {
        Debug.Log("Lose");
    }

    public IEnumerator startAnimationHeader()
    {
        Debug.Log("wait");
        coinAnimationHeader.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        anim.Play("HeadAnim");
        yield return new WaitForSeconds(1.20f);
        HeaderText.SetActive(true);
        yield return new WaitForSeconds(3f);
        coinAnimationHeader.SetActive(false);



    }

    private void startAnimationTail()
    {
        Debug.Log("Tail");
    }


}
