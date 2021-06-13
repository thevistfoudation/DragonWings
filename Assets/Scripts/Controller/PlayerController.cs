using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Animator Animation;
    public GameObject exp;
    // Start is called before the first frame update
    public GameObject dr1;
    public GameObject dr2;
    public GameObject dr3;
    public GameObject dr4;
    public GameObject dr5;
    void Start()
    {
        Animation = dr1.GetComponent<Animator>();
        Animation = dr2.GetComponent<Animator>();
        Animation = dr3.GetComponent<Animator>();
        Animation = dr4.GetComponent<Animator>();
        Animation = dr5.GetComponent<Animator>();
        Animation.Play("BOOTS");
    }

    void Update()
    {
        Animation.Play("NORMAL");
    }

    public void MoveplayerRight()
    {
        Animation.Play("RIGHT_FLAP");
        transform.position = new Vector2(transform.position.x + 0.96f, transform.position.y);
        Debug.Log("phari");
        
       // Debug.Log("phari");
    }
    public void MoveplayerLeft()
    {
        Animation.Play("LEFT_FLAP");
        transform.position = new Vector2(transform.position.x - 0.96f, transform.position.y);
        Debug.Log("trai");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BulletEnemy")
        {
            if (this.GetComponent<HpController>().hpplayer <= 0)
            {
                //Destroy(gameObject);
                GameObject go = Instantiate(exp, collision.transform.position, quaternion.identity);
                Destroy(go, 0.7f);
                GameController.instance.endgame();
            }
            else
            {
                this.GetComponent<HpController>().MinusHpplayer(collision.gameObject.GetComponent<BulletEnemyController>().damage);
            }
        }
        if (collision.gameObject.tag == "Enemy")
        {
            if (this.GetComponent<HpController>().hpplayer <= 0)
            {
                //Destroy(gameObject);
                GameObject go = Instantiate(exp, collision.transform.position, quaternion.identity);
                Debug.Log("End");
                Debug.Log("endgame");
                Destroy(go, 0.7f);
                GameController.instance.endgame();
                Time.timeScale = 0;
       
            }
            else
            {
                this.GetComponent<HpController>().MinusHpplayer(collision.gameObject.GetComponent<EnemyController>().damage);
            }
        }
        if (collision.gameObject.tag == "WallLeft")
        {
            this.transform.position = new Vector2(-1.670583f, -2.936f);
            Debug.Log("cham tg trai");
        }
        if (collision.gameObject.tag == "WallRight")
        {
           this.transform.position = new Vector2(1.315739f, -2.936f);
            Debug.Log("cham tg Phai");
        }

    }
  
}
