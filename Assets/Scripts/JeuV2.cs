using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuV2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquettePoints;
    [SerializeField] private TextMeshProUGUI _etiquetteSecondes;


    public int pointsJeu = 0;
    public int secondes = 0;

    void Start()
    {
        pointsJeu = 0;
        secondes = 0;
        InvokeRepeating("AugmenterTemps", 1f, 1f);
    }

    public void AugmenterPoints()
    {
        // Augmenter les points du jeu
        pointsJeu++;
        // Actualiser l'UI
        _etiquettePoints.text = "$" + pointsJeu.ToString();

      
       

    }
    public void AugmenterTemps()
    {
     
        _etiquetteSecondes.text = secondes.ToString() + "s";
        secondes++;
    }


}
