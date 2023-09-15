using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageRender : MonoBehaviour
{
    public int index, pageCount;
    public GameObject[] pages;

    public int GetIndex()
    {
        return index;
    }

    public void SetIndex(int n)
    {
        index = Mathf.Min(pageCount - 1, n);
    }

    public void Deactivate(int n)
    {
        pages[n].SetActive(false);
    }


    void Start()
    {
        index = 0;
        pageCount = pages.Length;
    }

    void Update()
    {
        pages[index].SetActive(true);
    }
}
