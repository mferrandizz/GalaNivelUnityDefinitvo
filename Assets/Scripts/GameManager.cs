using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private Animator anim;

    private AudioManager audioManager;
    private BackgroundManager backgroundManager;


    public int vidas = 5;
    public Text vidasText;
    public bool isGameOver = false;
    

    void Start()
    {
        anim = GameObject.Find("Player").GetComponent<Animator>();
    }

    void Awake()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        backgroundManager = GameObject.Find("BackgroundManager").GetComponent<BackgroundManager>();
    }

    public void CharacterDead(GameObject character)
    {
        //Ha muerto nuestro personaje, sonara un sonido, pararemos el juego (StopBGM), cargaremos la escena de Game Over y destruiremos el personaje
        //Debug.Log("Has muerto maja");
        audioManager.GameOverSound();
        backgroundManager.StopBGM();
        anim.SetTrigger("isDeath");
        isGameOver = true;
        //Destroy(character, 1f);
        //Time.timeScale = 0;
    }

    public void ZonaHit(GameObject zona)
    {
        //Hemos impactado contra la zona peligrosa, hacemos la animacion de impacto y el sonido 
        audioManager.LaserSound();
        //Debug.Log("ouch (Anim y sonido)");
    }

    public void RestarVida(GameObject character)
    {
        if(isGameOver == false)
        {
            //Restamos vidas
            vidas--;
            Debug.Log(vidas);
            vidasText.text = vidas.ToString();
            anim.SetTrigger("isDamaged");

            //Miramos si las vidas han llegado a 0 y en caso de que si el personaje se destruye
            if(vidas == 0)
            {
                CharacterDead(character);

            }
        }
    }

}
