using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{ 
    public float X { get; private set; }
    public float Y { get; private set; }

    void Update()
    {
        // 이전값을 날리고 기본 값으로 초기화.
        X = Y = 0f;


        // 현재프레임의 입력값을 저장.
        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");

    }


}