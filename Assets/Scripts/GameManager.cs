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

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Awake()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        backgroundManager = GameObject.Find("BackgroundManager").GetComponent<BackgroundManager>();
    }

    public void CharacterDead(GameObject character)
    {
        //Ha muerto nuestro personaje, sonara un sonido, pararemos el juego (StopBGM), cargaremos la escena de Game Over y destruiremos el personaje
        Debug.Log("Has muerto maja");
        audioManager.GameOverSound();
        backgroundManager.StopBGM();
        anim.SetTrigger("isDeath");
        Destroy(character, 0.3f);
        //Time.timeScale = 0;
    }

    public void ZonaHit(GameObject zona)
    {
        //Hemos impactado contra la zona peligrosa, hacemos la animacion de impacto y el sonido 
        audioManager.LaserSound();
        Debug.Log("ouch (Anim y sonido)");
    }

    public void RestarVida(GameObject character)
    {
        //Restamos vidas
        vidas--;
        Debug.Log(vidas);

        //Miramos si las vidas han llegado a 0 y en caso de que si el personaje se destruye
        if(vidas == 0)
        {
            CharacterDead(character);

        }

    }
    


}
