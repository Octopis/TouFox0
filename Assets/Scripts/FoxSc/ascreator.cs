using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ascreator : MonoBehaviour
{
    Stopwatch stopwatch;
    Stopwatch timingboss;
    public GameObject AsteroidL;
    public GameObject AsteroidS;
    public GameObject Boss;
    public float x = 0;
    public float y = 0;
    private int i = 0;

    void create_LAst()//fonction pour cr�e les gros ast�roide
    {
        if (i== 0)//la fonction cr�e deux ast�roide une qui spawn a gauche et une a droite
        {
            x = Random.Range(0, 2);//pour cr�e une valeurs al�atoire pour x 
            y = Random.Range(-2, 2);//pour cr�e une valeurs al�atoire pour y
            GameObject LAsteroid = Instantiate(AsteroidL, new Vector3(x, y, 10), Quaternion.identity) as GameObject;//cr�ation de l'ast�roide
            i++;
        }
        if (i == 1)//meme chose mais pour un spawn d'ast�roide a gauche
        {
            x = Random.Range(0, 2);
            y = Random.Range(-2, 2);
            GameObject LAsteroid = Instantiate(AsteroidL, new Vector3(-x, -y, 10), Quaternion.identity) as GameObject;
            i--;
        }

    }
    void create_SAst()//fonction pour cr�e les petit ast�roide
    {
        if (i == 0)//la fonction cr�e deux ast�roide une qui spawn a gauche et une a droite
        {
            x = Random.Range (0,2);//pour cr�e une valeurs al�atoire pour x
            y = Random.Range (-2,2);//pour cr�e une valeurs al�atoire pour y
            GameObject SAsteroid = Instantiate(AsteroidS, new Vector3(x, y, 10), Quaternion.identity) as GameObject;
            i++;
        }
        if (i == 1)//meme chose mais pour un spawn d'ast�roide a gauche
        {
            x = Random.Range(0,2);
            y = Random.Range(-2,2);
            GameObject SAsteroid = Instantiate(AsteroidS, new Vector3(-x, y, 10), Quaternion.identity) as GameObject;
            i--;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        stopwatch = new Stopwatch();
        timingboss = new Stopwatch();

        timingboss.Start();
        stopwatch.Start();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timingboss.ElapsedMilliseconds > 50000.0f)//test pour le timeur du boss une fois spawn les ast�roides de swapn plus
        {
            GameObject Boosspawn = Instantiate(Boss, new Vector3(0, 0, 10), Quaternion.Euler (0f, 180f, 0f)) as GameObject;//spawn du boss
            timingboss.Restart();//pour restart le timeur boss
            timingboss.Stop();//pour arr�t� le timeur du boss
            stopwatch.Stop();//pour arr�t� le timeur du spawn des ast�roides
        }
        else
        {
            if (stopwatch.ElapsedMilliseconds == 1500.0f)//pour faire spawn les ast�roides une plus courte avec que des petits ast�roides
            {
                create_SAst();
                create_SAst();
                create_SAst();
            }
            if (stopwatch.ElapsedMilliseconds > 4000.0f)//pour faire spawn les ast�roides avec des gros ast�roides et des petites ast�roides
            {
                create_LAst();
                create_LAst();
                create_SAst();
                create_SAst();
                create_SAst();
                stopwatch.Restart();//pour restart le timeur des ast�roides
            }
        }
    }
}
