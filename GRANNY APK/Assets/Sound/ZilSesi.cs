using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZilSesi : MonoBehaviour
{
    public AudioSource ZilSes;
    public GameObject ip;
    void Start()
    {
    
    }

   

    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ip")
        {
            SesOynat();

        }

    }
    void SesOynat()
    {
        ZilSes.Play();
       
    }
}
