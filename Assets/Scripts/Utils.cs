using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ġ,ȸ��,ũ�⸦ �����ϴ� PRSŬ���� ����
[System.Serializable]
public class PRS
{
    public Vector3 pos;
    public Quaternion rot;
    public Vector3 scale;

    //��ġ, ȸ��, ũ�⸦ �ʱ�ȭ �ϴ� ������
    public PRS(Vector3 pos, Quaternion rot, Vector3 scale)
    {
        this.pos = pos;
        this.rot = rot;
        this.scale = scale;
    }
}


// ��ƿ��Ƽ Ŭ���� Utils�� ������
public class Utils { 
   public static Quaternion QI => Quaternion.identity;
}
