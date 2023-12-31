using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Movement2D movement2D;

    [SerializeField]private Stage_Data stagedata;
    [SerializeField] private Weapon weapon;
    //private bool isHit = false;//히트하면 트루값으로 들어감
    private int Hit_Count = 0;//3회 타격이 되면 die 애니메이션

    private void Awake()
    {
        movement2D = transform.GetComponent<Movement2D>();
        weapon = transform.GetComponent<Weapon>();
    }
    private void Start()
    {
        if(movement2D.Move_Speed<=0f)
        {
            movement2D.Move_Speed = 5f;
        }
    }
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        movement2D.MoveTo(new Vector3(x, y, 0));

        if(Input.GetKeyDown(KeyCode.Space))
        {
            weapon.StartFire();
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            weapon.StopFire();
        }

    }
    private void LateUpdate()
    {
        //플레이어가 화면 범위 바깥으로 나가지 못하도록 설정
        transform.position = new Vector3
            (
            Mathf.Clamp(transform.position.x,stagedata.LimitMin.x,stagedata.LimitMax.x),
            Mathf.Clamp(transform.position.y,stagedata.LimitMin.y,stagedata.LimitMax.y),
            0
            );
    }



        private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy_Bullet"))
        {
            Hit_Count++;
        }
        if(Hit_Count==3)
        {
            //isHit = true;
            Debug.Log("뒤졌음");
        }
    }


}
