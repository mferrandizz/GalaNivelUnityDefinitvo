using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    //private AudioManager audioManager;
    //private BackGroundManager backgroundManager;

    public int vidas = 3;

    public void CharacterDead(GameObject character)
    {
        //Ha muerto nuestro personaje, sonara un sonido, pararemos el juego (StopBGM), cargaremos la escena de Game Over y destruiremos el personaje
        Debug.Log("Has muerto maja");
    }

    public void ZonaHit(GameObject zona)
    {
        //Hemos impactado contra la zona peligrosa, hacemos la animacion de impacto y el sonido 
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
