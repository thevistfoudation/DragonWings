using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JinGroupUnityBase.Base.Plane;

public class GamePlayer : MonoBehaviour
{
    public GameObject Menu11;

    //public GameObject menu;
    public Animator Animation;
   
    public static GamePlayer instance;
  
    public GameObject panelSetting;

  
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //Animation = menu.GetComponent<Animator>();
    }

    public void Exit()
    {
        panelSetting.SetActive(false);
    }
    public void Setting()
    {
        panelSetting.SetActive(true);
    }

    public void Play1()
    {
        StartCoroutine(_play());
        
        Animation.Play("2WAKE UP");
    }
    IEnumerator _play()
    {
        Debug.LogError("LOADSCENE 111");
        yield return new WaitForSeconds(2.5f);
        Menu11.GetComponent<BackGroundController>().scrollspeed = 0.09f;
        yield return new WaitForSeconds(1.3f);
        SceneManager.LoadScene(1);
        Debug.LogError("LOADSCENE");
    }    
}
  
