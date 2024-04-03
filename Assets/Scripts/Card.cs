using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class Card : MonoBehaviour
{
    [SerializeField] SpriteRenderer card; //ī�� ��������Ʈ ������
    [SerializeField] SpriteRenderer character; //ĳ���� ��������Ʈ ������
    [SerializeField] TMP_Text nameTMP; //�̸��� ǥ���ϴ� TMP
    [SerializeField] TMP_Text attackTMP; //���ݷ��� ǥ���ϴ� TMP
    [SerializeField] TMP_Text healthTMP; //ü���� ǥ���ϴ� TMP
    [SerializeField] Sprite cardFront; //ī���� �ո� ��������Ʈ
    [SerializeField] Sprite cardBack; //ī���� �޸� ��������Ʈ

    public Item item; //ī�忡 ���� ���� ������ ����
    bool isFront; //ī���� ���� �ո� ����
    public PRS originPRS; //ī���� �ʱ���ġ,ȸ��,ũ�� ����


    //ī�带 �����ϴ� �޼���
    public void Setup(Item item, bool isFront)
    {
        this.item = item;
        this.isFront = isFront;

        if (this.isFront)
        {
            character.sprite = this.item.sprite;
            nameTMP.text = this.item.name;
            attackTMP.text = this.item.attack.ToString();
            healthTMP.text = this.item.health.ToString();
        }
        else
        {
            card.sprite = cardBack;
            nameTMP.text = "";
            attackTMP.text = "";
            healthTMP.text = "";
        }
    }

    //ī�带 �̵� ��Ű�� �޼���
    public void MoveTransform(PRS prs, bool useDotween, float dotweenTime = 0)
    {
        //DoTween�� ����Ͽ� ī�带 ���ϴ� ��ġ,ȸ��,ũ��� �̵���Ŵ
        if (useDotween)
        {
            transform.DOMove(prs.pos, dotweenTime);
            transform.DORotateQuaternion(prs.rot, dotweenTime);
            transform.DOScale(prs.scale, dotweenTime);
        }

        //DoTween�� ������� �ʰ� ī�带 ���ϴ� ��ġ,ȸ��,ũ��� �̵���Ŵ
        else
        {
            transform.position = prs.pos;
            transform.rotation = prs.rot;
            transform.localScale = prs.scale;
        }
    }


}
