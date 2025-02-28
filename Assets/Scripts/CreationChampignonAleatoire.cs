using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationChampignonAleatoire : MonoBehaviour
{
    public GameObject champignons;
    public GameObject  boite;
    public GameObject drapeau;

    // Start is called before the first frame update
    void Start()
    {
      float randomValue = Random.value;

        if(randomValue > 0.5f)
        {
            champignons.transform.position = drapeau.transform.position;

        }
        else
        {
            champignons.transform.position = boite.transform.position;
        }
    }

}
