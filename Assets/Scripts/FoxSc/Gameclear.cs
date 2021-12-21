using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameclear : MonoBehaviour//script pour faire apparaitre le screen de victoire une fois le boss mort
{
    // Start is called before the first frame update
    public Text pointsText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);//pour faire apparaitre le screen
        pointsText.text = score.ToString() + " POINTS";//pour affich� le score du jeu
    }
    public void RestartButton()//fonction pour faire fonction� le bouton restart du l'ecran victory 
    {
        SceneManager.LoadScene("Foxproject");//pour restart le jeu
    }
    public void ExitButton()//fonction pour faire fonction� le bouton main menu du l'ecran victory 
    {
        //SceneManager.LoadScene("MainMenu");//pour revenir au menu du jeu
    }
}
