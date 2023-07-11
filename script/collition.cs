using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collition : MonoBehaviour
{
    public GameObject gameover;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "obstacle")
        {
            GameOver();
        }
    }

    private void GameOver()
    {

        gameover.SetActive(true);
       
    }

}

