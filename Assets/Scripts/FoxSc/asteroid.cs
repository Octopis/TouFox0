using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class asteroid : MonoBehaviour//script pour les deux ast�roide
{
    private float speed = 1f;
    [SerializeField] private int live;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 15f);//pour que quand l'ast�roide d�pop quand il est plus dans l'�cran
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.back * speed * Time.deltaTime);//pour d�plac� les ast�roide vers le personnage
    }
    void OnCollisionEnter(Collision Coll)//pour la vie des asst�roides
    {
        live--;
        if(live == 0)
            Destroy(gameObject);
    }
}

