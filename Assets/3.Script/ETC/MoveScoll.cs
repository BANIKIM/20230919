using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScoll : MonoBehaviour
{
    [SerializeField] private float Speed;

    private void Update()
    {
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
    }
}
