using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//////////////////////////////////////////////
//Assignment/Lab/Project: Animations
//Name: Hunter Wright
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 4/15/2024
/////////////////////////////////////////////
public class DoorController : MonoBehaviour
{
    public bool isOpen;
    private Animator doorAnimator;
    // Start is called before the first frame update
    void Start()
    {
        doorAnimator = GetComponent<Animator>();
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleDoor()
    {
        if (isOpen)
        {
            doorAnimator.SetTrigger("CloseDoor");
            isOpen = false;

        }
        else if (!isOpen)
        {
            doorAnimator.SetTrigger("OpenDoor");
            isOpen = true;

        }
    }
}
