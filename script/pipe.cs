using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float speed = 5f;
    public float leftedge;
    private void Start()
    {
        leftedge = Camera.main.ScreenToWorldPoint(Vector3.zero).x-1f;
    }
    public void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x < leftedge)
        {
            Destroy(gameObject);
        }
    }
}
