﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MapRespone : MonoBehaviour
{
    [SerializeField] protected Ease ease;
  
    public void AddMapMove(){
        transform.DOLocalMove(Vector3.zero, 2).SetEase(ease);
    }

    public void DropMapMove() {
        StartCoroutine(DropMap());
    }

    IEnumerator DropMap()
    {
        transform.DOLocalMoveY(-30, 4).SetEase(Ease.OutExpo);
        yield return new WaitForSeconds(4f);
        gameObject.SetActive(false);
    }
}
