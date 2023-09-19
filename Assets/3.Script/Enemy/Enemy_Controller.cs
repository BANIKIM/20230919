using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    [SerializeField] private Weapon weapon;
    private int HitCount = 0;
    private void Awake()
    {
        weapon = transform.GetComponent<Weapon>();
        weapon.StartFire();
    }



    //플레이어
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player_Bullet"))
        {
            HitCount++;
            
        }
        if(HitCount==3)
        {
            Destroy(gameObject);
        }
    }

}
