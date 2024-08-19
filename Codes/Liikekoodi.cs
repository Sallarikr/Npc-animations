using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liikekoodi : MonoBehaviour
{
    void Start()
    {
        
    } // Start

    void Update()
    {
        
    } // Update

    // Pelaajan lähestymiseen reagointi9
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Pelaaja"))
        {
            this.GetComponent<Animator>().SetInteger("Tila", 1);
        } // if
    } // OnTriggerEnter

    // Pelaajan poistumiseen reagointi
     private void OnTriggerExit(Collider other)
    {
        if (other.name.Equals("Pelaaja"))
        {
            this.GetComponent<Animator>().SetInteger("Tila", 0);
        } // if
    } // OnTriggerExit
} // class
