using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithDoor : MonoBehaviour
{
    [SerializeField]
    GameObject doorCanvas;
    [SerializeField]
    Animator animator;
    [SerializeField]
    private bool playerHasKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            if (playerHasKey == true)
            {
                doorCanvas.SetActive(true);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           if (Input.GetKey(KeyCode.E))
            {
                
                animator.SetInteger("OpenDoor", 1);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            doorCanvas.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
