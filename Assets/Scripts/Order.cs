using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//���� ������Ʈ���� ���� ������ �����ϴ� Ŭ����
public class Order : MonoBehaviour
{
    [SerializeField] Renderer[] backRenderers; //��� ������ �迭 (�����)
    [SerializeField] Renderer[] middleRenderers; //�߰� ������ �迭 (ī��)
    [SerializeField] string sortingLayerName; //���� �ϴ� ���̾� �̸�
    int originOrder; //ó�� ���� ����

    //�ʱ� ���ļ����� �����ϴ� �޼���
    public void SetOriginOrder(int originOrder)
    {
        this.originOrder = originOrder;
        SetOrder(originOrder);
    }

    //���� �ռ����� �����ϴ� �޼��� 
    public void SetMostFrontOrder(bool isMostFront)
    {
        SetOrder(isMostFront ? 100 : originOrder);
    }

    //���� ������ �����ϴ� �޼���
    public void SetOrder(int order)
    {
        int mulOrder = order * 10;

        //��� �������� ���ļ��� ����
        foreach (var renderer in backRenderers)
        {
            renderer.sortingLayerName = sortingLayerName;
            renderer.sortingOrder = mulOrder;
        }

        //�߰� ���������� ���ļ��� ����
        foreach (var renderer in middleRenderers)
        {
            renderer.sortingLayerName = sortingLayerName;
            renderer.sortingOrder = mulOrder + 1;
        }
    }



}
