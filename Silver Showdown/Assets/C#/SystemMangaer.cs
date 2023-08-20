using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class SystemMangaer : MonoBehaviour
{
    public bool HorT = false;
    public bool BooleanHorT;

    public int HowManyTargets = 0;
    [SerializeField] Camera cam;
    
    [Header("Coin Header Anim")]

    [SerializeField] private GameObject HeaderText;
    [SerializeField] private GameObject coinAnimationHeader;
    public Animator animHeader;
    private TextMeshProUGUI HeaderTextColor;



    [Header("Coin Header Tails")]

    [SerializeField] private GameObject TailsText;
    [SerializeField] private GameObject coinAnimationTails;
    public Animator animTails;
    private TextMeshProUGUI TailsTextColor;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {
            Vector3 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePosition2D, Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("Target"))
            {

                Destroy(hit.collider.gameObject);
                HowManyTargets++;

            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.name);
    }

    private void AddPhysics2DRaycaster()
    {
        Physics2DRaycaster physicsRaycaster = FindObjectOfType<Physics2DRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
            Debug.Log("Clicked: " );
        }
    }

    private void Start()
    {
        AddPhysics2DRaycaster();
        // = HeaderText.GetComponent<TextMeshProUGUI>();
        //TailsTextColor = TailsText.GetComponent<TextMeshProUGUI>();

    }

    public void ChosingHorT()
    {
        BooleanHorT = (Random.value > 0.5f);
        if(HorT != BooleanHorT)
        {
            Lose();
        }
        else if(HorT == true && BooleanHorT == true)
        {
            //HeaderTextColor.color = new Color(0, 0, 0);
            StartCoroutine("startAnimationHeader");
        }
        else if (HorT == false && BooleanHorT == false)
        {
            //TailsTextColor.color = new Color(0, 0, 0);
            StartCoroutine("startAnimationTail");
        }
    }


    private void Lose()
    {
        if(BooleanHorT == true)
        {
            Debug.Log("Loose");
            //HeaderTextColor.color = new Color(255, 0, 0);
            StartCoroutine("startAnimationHeader");
        }
        else
        {
            Debug.Log("Loose");
            //TailsTextColor.color = new Color(255, 0, 0);
            StartCoroutine("startAnimationTail");
        }
    }

    public IEnumerator startAnimationHeader()
    {
        coinAnimationHeader.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        animHeader.Play("HeadAnim");
        yield return new WaitForSeconds(1.20f);
        HeaderText.SetActive(true);
        yield return new WaitForSeconds(3f);
        coinAnimationHeader.SetActive(false);
        HeaderText.SetActive(false);
    }

    public IEnumerator startAnimationTail()
    {
        coinAnimationTails.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        animTails.Play("TailsAnimation");
        yield return new WaitForSeconds(1.20f);
        TailsText.SetActive(true);
        yield return new WaitForSeconds(3f);
        coinAnimationTails.SetActive(false);
        TailsText.SetActive(false);
    }


}
