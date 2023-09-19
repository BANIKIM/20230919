using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_loop : MonoBehaviour
{
    private float width;

    void Start()
    {
        width = 9.9f;
    }

    private void Update()
    {
        if(transform.position.y <= -width)
        {
            Vector2 offset = new Vector2(0, width * 2f);
            transform.position = (Vector2)transform.position + offset;//()는 형변환을 하기 위해 사용
        }
    }
}
