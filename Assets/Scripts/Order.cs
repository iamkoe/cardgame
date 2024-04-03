using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//게임 오브젝트들의 정렬 순서를 제어하는 클래스
public class Order : MonoBehaviour
{
    [SerializeField] Renderer[] backRenderers; //배경 랜더러 배열 (배경판)
    [SerializeField] Renderer[] middleRenderers; //중간 랜더러 배열 (카드)
    [SerializeField] string sortingLayerName; //정렬 하는 레이어 이름
    int originOrder; //처음 정렬 순서

    //초기 정렬순서를 설정하는 메서드
    public void SetOriginOrder(int originOrder)
    {
        this.originOrder = originOrder;
        SetOrder(originOrder);
    }

    //가장 앞순서로 설정하는 메서드 
    public void SetMostFrontOrder(bool isMostFront)
    {
        SetOrder(isMostFront ? 100 : originOrder);
    }

    //정렬 순서를 설정하는 메서드
    public void SetOrder(int order)
    {
        int mulOrder = order * 10;

        //배경 렌더러의 정렬순서 설정
        foreach (var renderer in backRenderers)
        {
            renderer.sortingLayerName = sortingLayerName;
            renderer.sortingOrder = mulOrder;
        }

        //중간 렌더러들의 정렬순서 설정
        foreach (var renderer in middleRenderers)
        {
            renderer.sortingLayerName = sortingLayerName;
            renderer.sortingOrder = mulOrder + 1;
        }
    }



}
