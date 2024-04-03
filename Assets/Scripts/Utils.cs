using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 위치,회전,크기를 저장하는 PRS클래스 정의
[System.Serializable]
public class PRS
{
    public Vector3 pos;
    public Quaternion rot;
    public Vector3 scale;

    //위치, 회전, 크기를 초기화 하는 생성자
    public PRS(Vector3 pos, Quaternion rot, Vector3 scale)
    {
        this.pos = pos;
        this.rot = rot;
        this.scale = scale;
    }
}


// 유틸리티 클래스 Utils를 정의함
public class Utils { 
   public static Quaternion QI => Quaternion.identity;
}
