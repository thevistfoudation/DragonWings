using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JinGroupUnityBase.Base.Plane;

public class GameController : MonoBehaviour
{
    public GameObject Menu11;
    public GameObject Smk;
   // public GameObject menu;
    public Animator Animation;
    public GameObject Bomdb;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Drg1;
    public GameObject Drg2;
    public GameObject Drg3;
    public GameObject Drg4;
    public GameObject Drg5;
    public float scoreplayer;
    public static GameController instance;
    public Text score;
    public Text ketqua;
    public GameObject panelover;
    public GameObject panelPause;
    public GameObject panelSetting;
    public GameObject player;
    public GameObject Gate1;
    public GameObject Gate2;
    public GameObject Gate3;
    public GameObject Gate4;
    public GameObject Gate5;
    public GameObject Sound;
    public float delay;
    public int coin;
    public GameObject[] Bg;
    public GameObject GateItem;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Smk.SetActive(true);
        LeanTween.delayedCall(1f, () =>
        {
            Smk.SetActive(false);
        });
        //Animation = menu.GetComponent<Animator>();
        Enemy2.GetComponent<EnemyController>().speed = 2;
        Enemy3.GetComponent<EnemyController>().speed = 2f;
        // _coin();
        Time.timeScale = 1;
        scoreplayer = 0;
        //coin = JsonUtility.FromJson<inven>(PlayerPrefs.GetString("DATA")).coin;
        //Debug.Log("coin :" +coin  );
        //Debug.Log("SOluongitem1: " + JsonUtility.FromJson<inven>(PlayerPrefs.GetString("DATA")).item1);
         
    }
    private void OnEnable()
    {
        //dc goi moi khi dc active
        StartCoroutine(BonusScore());
    }
    // Update is called once per frame
    void Update()
    {
        score.text = "score : " + scoreplayer.ToString();
       // ketqua.text = "0" + scoreplayer.ToString();
    }
       IEnumerator BonusScore()
    {
        while (true)
        {
            scoreplayer += 1f ;
            yield return new WaitForSeconds(delay);
            if (scoreplayer >= 0 && scoreplayer < 30)
            {

                if(scoreplayer >=15 && scoreplayer < 30)
                {
                    Gate1.SetActive(false);
                }
                for (int i = 0; i < Bg.Length; i++)
                {

                    //Enemy1.GetComponent<EnemyController>().speed = 1.3f;
                    Bomdb.GetComponent<Rigidbody2D>().gravityScale = 2;
                    Enemy2.GetComponent<EnemyController>().speed = 2;
                    Enemy3.GetComponent<EnemyController>().speed = 2f;
                    //Destroy(Enemy1);
                    Bg[i].GetComponent<BackGroundController>().scrollspeed = 0.01f;
                    Debug.Log(Bg[i].GetComponent<BackGroundController>().scrollspeed);
                    Debug.Log("tang toc");
                    //chon 2 obj trg mang tang dan len den 2
                }
            }
            if (scoreplayer >= 30 && scoreplayer <60)
            {
                Gate2.SetActive(true);
                if (scoreplayer >= 45 && scoreplayer < 60)
                {
                    Gate2.SetActive(false);
                }
                if (scoreplayer == 30)
                {
                    Smk.SetActive(true);
                    LeanTween.delayedCall(1f, () =>
                    {
                        Smk.SetActive(false);
                    });
                }
                Drg1.SetActive(false);
                Drg2.SetActive(true);
                for (int i = 0; i< Bg.Length; i++)
                {

                    //Enemy1.GetComponent<EnemyController>().speed = 1.3f;
                    Bomdb.GetComponent<Rigidbody2D>().gravityScale = 3;
                    Enemy2.GetComponent<EnemyController>().speed = 2;
                    Enemy3.GetComponent<EnemyController>().speed = 2f;
                    //Destroy(Enemy1);
                    Bg[i].GetComponent<BackGroundController>().scrollspeed = 0.01f;
                    Debug.Log( Bg[i].GetComponent<BackGroundController>().scrollspeed);
                    Debug.Log("tang toc");
                    //chon 2 obj trg mang tang dan len den 2
                }
            }
            if (scoreplayer >= 60 && scoreplayer < 90)
            {

                Gate3.SetActive(true);
                if (scoreplayer >= 75 && scoreplayer < 90)
                {
                    Gate3.SetActive(false);
                }
                if (scoreplayer == 60)
                {
                    Smk.SetActive(true);
                    LeanTween.delayedCall(1f, () =>
                    {
                        Smk.SetActive(false);
                    });
                }
                Drg2.SetActive(false);
                Drg3.SetActive(true);
                for (int i = 0; i < Bg.Length; i++)
                {
                    Bomdb.GetComponent<Rigidbody2D>().gravityScale = 4;
                    //Enemy1.GetComponent<EnemyController>().speed = 2.5f;
                    Enemy2.GetComponent<EnemyController>().speed = 4f;
                    Enemy3.GetComponent<EnemyController>().speed = 4f;
                     
                    Bg[i].GetComponent<BackGroundController>().scrollspeed = 0.02f;
                    
                    Debug.Log("tang toc");
                    //chon 2 obj trg mang tang dan len den 2
                }
            }
            if (scoreplayer >= 90 && scoreplayer < 120)
            {

                Gate4.SetActive(true);
                if (scoreplayer >= 105 && scoreplayer < 120)
                {
                    Gate4.SetActive(false);
                }
                if (scoreplayer == 90)
                {
                    Smk.SetActive(true);
                    LeanTween.delayedCall(1f, () =>
                    {
                        Smk.SetActive(false);
                    });
                }
                Drg3.SetActive(false);
                Drg4.SetActive(true);
                for (int i = 0; i < Bg.Length; i++)
                {
                    //Enemy1.GetComponent<EnemyController>().speed = 6.3f;
                    Bomdb.GetComponent<Rigidbody2D>().gravityScale = 5;
                    Enemy2.GetComponent<EnemyController>().speed = 8f;
                    Enemy3.GetComponent<EnemyController>().speed = 8f;
                    Bg[i].GetComponent<BackGroundController>().scrollspeed = 0.05f;
                    //Enemy1.GetComponent<EnemyController>().speed = 4.5f;
                    Debug.Log("tang toc");
                    //chon 2 obj trg mang tang dan len den 2
                }
            }
            if (scoreplayer >= 120 && scoreplayer < 150)
            {
                if (scoreplayer == 120)
                {
                    Smk.SetActive(true);
                    LeanTween.delayedCall(1f, () =>
                    {
                        Smk.SetActive(false);
                    });
                }
                Gate5.SetActive(true);
                Drg4.SetActive(false);
                Drg5.SetActive(true);
                for (int i = 0; i < Bg.Length; i++)
                {
                    // Enemy1.GetComponent<EnemyController>().speed = 12.6f;
                    Bomdb.GetComponent<Rigidbody2D>().gravityScale = 10;
                    Enemy2.GetComponent<EnemyController>().speed = 15f;
                    Enemy3.GetComponent<EnemyController>().speed = 15f;
                    Bg[i].GetComponent<BackGroundController>().scrollspeed = 0.1f;
                    Debug.Log("tang toc");
                    //chon 2 obj trg mang tang dan len den 2
                }
            }
        }
    }

    public void playSound()
    {
        Sound.SetActive(false);
    }
    public void Exit()
    {
        panelSetting.SetActive(false);
    }
    public void Setting()
    {
        panelSetting.SetActive(true);
    }
    public void addscore()
    {
        scoreplayer += 10;
    }
    public void endgame()
    {
        panelover.SetActive(true);
        Time.timeScale = 0;
        ketqua.text = "" + scoreplayer.ToString();
    }
    public void Playagain()
    {
        SceneManager.LoadScene(2);
        //panelover.SetActive(false);
    }
    public void Play1()
    {

        LeanTween.delayedCall(2.5f, () =>
        {
            Menu11.GetComponent<BackGroundController>().scrollspeed = 0.09f;
        });
        LeanTween.delayedCall(3.5f, () =>
        {
            SceneManager.LoadScene(1);
           
        });
        Animation.Play("2WAKE UP");
    }
    public void Play2()
    {
        SceneManager.LoadScene(1);
    }

    //public void restart()
    //{
    //    SceneManager.LoadScene(0);
    //}
    public void Play()
    {
        Time.timeScale = 1;
        panelPause.SetActive(false);
    }
    public void Pause()
    {
        Time.timeScale = 0;
        panelPause.SetActive(true);
    }
   
    //void save()
    //{
    //    data _data = new data
    //    {
    //        score = scoreplayer,
            
    //    };
    //    PlayerPrefs.SetString("DATA", JsonUtility.ToJson(_data));

        
    //}
    //void gettt(string js)
    //{
    //    scoreplayer =  JsonUtility.FromJson<data>(PlayerPrefs.GetString("DATA")).score;
    //}
    //class data
    //{
    //    public int score,coin;
    //}
    public void buy(int n)
    {
        switch(n)
        {
            case 1: // mua item 1
              int _item1 =  JsonUtility.FromJson<inven>(PlayerPrefs.GetString("DATA")).item1 += 1;
              int _coin =   JsonUtility.FromJson<inven>(PlayerPrefs.GetString("DATA")).coin -= 1000;

                inven iv = new inven
                {
                    coin = _coin,
                    item1 = _item1
                };

                PlayerPrefs.SetString("DATA", JsonUtility.ToJson(iv));
                break;
        }
    }
    void showinven(string js)
    {
        int coin = JsonUtility.FromJson<inven>(js).coin;
        int item1 = JsonUtility.FromJson<inven>(js).item1;
        int item2 = JsonUtility.FromJson<inven>(js).item2;
    }

    class inven
    {
        public int coin;
        public int item1, item2;
    }
    void _coin()
    {
        inven iv = new inven
        {
            coin = 10000,
        };
        PlayerPrefs.SetString("DATA", JsonUtility.ToJson(iv));
    }
}


