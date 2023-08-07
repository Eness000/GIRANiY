using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupController : MonoBehaviour
{
    public GameObject Tool;
    public Transform WeaponParent;
    void Start()
    {
        Tool.GetComponent<Rigidbody>().isKinematic = true;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            Drop();
        }
    }

    void Drop()
    {
        WeaponParent.DetachChildren();
        Tool.transform.eulerAngles = new Vector3(Tool.transform.position.x, Tool.transform.position.z, Tool.transform.position.y);
        Tool.GetComponent<Rigidbody>().isKinematic = false;
        Tool.GetComponent<MeshCollider>().enabled = true;
    }

    void Equip()
    {
        Tool.GetComponent<Rigidbody>().isKinematic = true;

        Tool.transform.position = WeaponParent.transform.position;
        Tool.transform.rotation = WeaponParent.transform.rotation;

        Tool.GetComponent<MeshCollider>().enabled = false;

        Tool.transform.SetParent(WeaponParent);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetKey(KeyCode.F))
            {
                Equip();
               
            }
        }

    }
}
