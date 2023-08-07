using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public Transform HideTransform;
    public Transform HideTransform2;
    public Transform HideTransform3;
    public Transform KameraTransform;
    public GameObject Player;
    public GameObject Camera;
    bool Saklanýldý;

    void Start()
    {
        
    }


    void Update()
    {
        
    }
   
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "SaklanmaYeri")
        {
            if (Input.GetKey(KeyCode.F))
            {
                Saklanma();
                Saklanýldý = true;

            }
        }
        if (other.gameObject.tag == "SaklanmaYeri2")
        {
            if (Input.GetKey(KeyCode.F))
            {
                Saklanma2();

            }
        }
        


    }

    void Saklanma()
    {
        Camera.transform.position = HideTransform.transform.position;
        Camera.transform.rotation = HideTransform.transform.rotation;
        Camera.GetComponent<MouseLook>().enabled = false;
        Player.GetComponent<CharacterController>().enabled = false;
        if (Input.GetKey(KeyCode.W))
        {
            Camera.transform.position = KameraTransform.transform.position;
            Camera.transform.rotation = KameraTransform.transform.rotation;
            Camera.GetComponent<MouseLook>().enabled = true;
            Player.GetComponent<CharacterController>().enabled = true;
        }



    }
    void Saklanma2()
    {
        Camera.transform.position = HideTransform2.transform.position;
        Camera.transform.rotation = HideTransform2.transform.rotation;
        Camera.GetComponent<MouseLook>().enabled = false;
        Player.GetComponent<CharacterController>().enabled = false;
    }
    void Saklanma3()
    {
        Camera.transform.position = HideTransform3.transform.position;
        Camera.transform.rotation = HideTransform3.transform.rotation;
        Camera.GetComponent<MouseLook>().enabled = false;
        Player.GetComponent<CharacterController>().enabled = false;
    }

}
