using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwanpipe : MonoBehaviour
{
 public GameObject prefab;

    public float swanRate = 1f;
    public float minHight = -1f;
    public float maxHight = 1f;
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn),swanRate,swanRate);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHight, maxHight);
    }
}
