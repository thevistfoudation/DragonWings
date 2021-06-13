using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace JinGroupUnityBase.Base.Plane {
    public class GateController : MonoBehaviour
    {
        #region Var
        //public Animator Animation;
        public GameObject[] poinSpawn;
        //mảng cái cổng thả
        public GameObject[] enemy;
        // tập hợp enemy
        public GameObject[] item;
        // tập hợp các Item
        #endregion

        #region Unity Method
        private void Update()
        {
          
        }
        void Start()
        {
            //Animation = GetComponent<Animator>();
            StartCoroutine(Spawn());
            StartCoroutine(spawnItem());
        }
        IEnumerator Spawn()
        {//hàm thả random tự do quân địch bay xuống (ko chịu tác dụng của trọng lực)
            while (true)
            {
                int randomIndex = Random.Range(0, enemy.Length);
                int randomIndex1 = Random.Range(0, poinSpawn.Length);
               // Animation.Play("thaboom");
                GameObject instantiatedObject = Instantiate(enemy[randomIndex], poinSpawn[randomIndex1].transform.position, Quaternion.identity) as GameObject;
                yield return new WaitForSeconds(3f);
               // Animation.Play("thaboom");
            }
        }
        IEnumerator spawnItem()
        { //hàm random thả tự do item rơi xuống(chịu tác dụng của trọng lực )
            while (true)
            {
                int randomIndex = Random.Range(0, item.Length);
                int randomIndex1 = Random.Range(0, poinSpawn.Length);
                GameObject instantiatedObject = Instantiate(item[randomIndex], poinSpawn[randomIndex1].transform.position, Quaternion.identity) as GameObject;
                yield return new WaitForSeconds(4f);
            }
        }
    }
    #endregion
}

