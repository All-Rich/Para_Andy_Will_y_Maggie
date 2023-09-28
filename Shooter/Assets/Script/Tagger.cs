using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tagger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision) 
    { 
        if(collision.gameObject.tag=="Zombie")
        {
            Debug.Log("Me lleva la vergaaaa");
            Destroy(collision.gameObject);
        }
    }
}
