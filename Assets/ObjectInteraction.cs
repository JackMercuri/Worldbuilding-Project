using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public float RaycastDistance = 2f;



    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.forward * RaycastDistance);

        if (Physics.Raycast(transform.position,transform.forward, out hit, RaycastDistance))
        {
            if (hit.collider.gameObject.tag == "Interactable")
            {
                Debug.Log("Yos");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.gameObject.GetComponent<InteractionRecieve>().Action();
                    
                }
            }
        }



    }
}
