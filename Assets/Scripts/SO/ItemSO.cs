using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;


[System.Serializable]
public class Item
{
    public string name; //아르카나 카드 이름
    public int attack;  //아르카나 카드의 공격력
    public int health;  //아르카나 카드의 체력
    public Sprite sprite; //카드의 이미지 스프라이트
    public float percent; //아이템과 관련된 임시의 값
}

[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Object/ItemSO")]
public class ItemSO : ScriptableObject
{
    public Item[] items; //Item 저장하는 배열
}