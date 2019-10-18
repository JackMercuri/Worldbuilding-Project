using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionRecieve : MonoBehaviour
{
    public Animator anim;
    public string stateName;
    bool currentState;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentState = anim.GetBool(stateName);
    }

    public void Action()
    {
        if (currentState == false)
        {
            anim.SetBool(stateName, true);
        } else
        {
            anim.SetBool(stateName, false);
        }
    }
}
