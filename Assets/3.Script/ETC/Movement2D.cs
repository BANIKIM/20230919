using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    /*
     전체적으로 관리하는 manager 역활을 하는 컴포넌트 스크립트
      다른 컴포넌트의 참조가 필요함. 
    
    하나하나 기능들을 구현하는 스크립트 
        구지 다른 컴포넌트를 가지고 올 필요가 없습니다....
     */



    public float Move_Speed = 0f;
    [SerializeField]
    private Vector3 moveDirection = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        transform.position += moveDirection * Move_Speed * Time.deltaTime;
    }

    public void MoveTo(Vector3 direction)
    {
        moveDirection = direction;
    }

}
