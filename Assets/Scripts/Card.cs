using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class Card : MonoBehaviour
{
    [SerializeField] SpriteRenderer card; //카드 스프라이트 렌더러
    [SerializeField] SpriteRenderer character; //캐릭터 스프라이트 렌더러
    [SerializeField] TMP_Text nameTMP; //이름을 표시하는 TMP
    [SerializeField] TMP_Text attackTMP; //공격력을 표시하는 TMP
    [SerializeField] TMP_Text healthTMP; //체력을 표시하는 TMP
    [SerializeField] Sprite cardFront; //카드의 앞면 스프라이트
    [SerializeField] Sprite cardBack; //카드의 뒷면 스프라이트

    public Item item; //카드에 대한 현재 아이템 정보
    bool isFront; //카드의 현재 앞면 여부
    public PRS originPRS; //카드의 초기위치,회전,크기 정보


    //카드를 설정하는 메서드
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

    //카드를 이동 시키는 메서드
    public void MoveTransform(PRS prs, bool useDotween, float dotweenTime = 0)
    {
        //DoTween을 사용하여 카드를 원하는 위치,회전,크기로 이동시킴
        if (useDotween)
        {
            transform.DOMove(prs.pos, dotweenTime);
            transform.DORotateQuaternion(prs.rot, dotweenTime);
            transform.DOScale(prs.scale, dotweenTime);
        }

        //DoTween을 사용하지 않고 카드를 원하는 위치,회전,크기로 이동시킴
        else
        {
            transform.position = prs.pos;
            transform.rotation = prs.rot;
            transform.localScale = prs.scale;
        }
    }


}
