using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public Animator a;
    void Start()
    {
        a =GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        a.Play("BOOTS");
    }
}
