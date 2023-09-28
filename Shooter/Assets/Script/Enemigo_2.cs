using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemigo_2 : MonoBehaviour
{
    public Transform[] points;
    int current;
    public float speed;

    void Start()
    {
        current = 0;
    }

    private void Update()
    {
        if(transform.position != points[current].position) 
        { 
            transform.position = Vector3.MoveTowards(transform.position, points[current].position, speed*Time.deltaTime);
        
        }
        else
        {
            current= (current+1)%points.Length;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            SceneManager.LoadScene(4);
        }
    }
}