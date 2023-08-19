using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Header : MonoBehaviour
{
    public SystemMangaer systemMangaer;

    private void OnTriggerStay2D(Collider2D collision)  
    {
        systemMangaer.HorT = true;
    }
}
