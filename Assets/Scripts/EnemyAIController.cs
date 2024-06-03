using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using Arsh.Scripts;

public class EnemyAIController : MonoBehaviour
{
    private PlayerController playerController;
    public float health;
    public Slider healthSlider;



    private void Awake()
    {
        health = 100;
    }

    private void Update()
    {
        healthSlider.value = health;
    }
    //when enemy attacks
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Reduce player's health
            other.gameObject.GetComponent<PlayerController>().TakeDamage(5);
            //playerController.healthSlider.value = PlayerController.health;
        }
        /*
        if(health<=0){
            DestroyEnemy();
        }
        */
    }


}


