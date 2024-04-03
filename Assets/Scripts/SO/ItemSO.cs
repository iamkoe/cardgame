using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;


[System.Serializable]
public class Item
{
    public string name; //�Ƹ�ī�� ī�� �̸�
    public int attack;  //�Ƹ�ī�� ī���� ���ݷ�
    public int health;  //�Ƹ�ī�� ī���� ü��
    public Sprite sprite; //ī���� �̹��� ��������Ʈ
    public float percent; //�����۰� ���õ� �ӽ��� ��
}

[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Object/ItemSO")]
public class ItemSO : ScriptableObject
{
    public Item[] items; //Item �����ϴ� �迭
}