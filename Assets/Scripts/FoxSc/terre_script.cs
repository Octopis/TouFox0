using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terre_script : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);//pour faire avanc� le fond ou la plannet pour donn� une impr�sion de mouvement
    }
}
