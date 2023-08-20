using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GrugAndGropo : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;

    [SerializeField] GameObject obj;
    public bool CanMoveCoin = true;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public SystemMangaer systemMangaer;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
       
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = .8f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(CanMoveCoin == true)
        {
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    private void Update()
    {
        if(CanMoveCoin == false)
        {
            StartCoroutine("Wait");
        }
    }


        public IEnumerator Wait()
        {
            Debug.Log("wait");
            yield return new WaitForSeconds(3f);
            obj.SetActive(false);
            systemMangaer.ChosingHorT();
        }
}
