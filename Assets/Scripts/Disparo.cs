using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public int fuerzaDisp = 10;
    private Rigidbody rb;
    private GameManager gameManager;
    private AudioManager audioManager;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    void Update()
    {
        transform.position += transform.forward * fuerzaDisp * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Te ha dado un disparo de torreta");
            audioManager.ShotHitSound();
            
            gameManager.RestarVida(this.gameObject);
        }

        this.gameObject.SetActive(false);
        
    }
}
