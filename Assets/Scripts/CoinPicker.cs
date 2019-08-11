using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    private AudioSource coinPickSound; 
   
    void Start()
    {
        coinPickSound = GameObject.Find("CoinPickSound").GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player"){
            gameObject.SetActive(false);
            if(coinPickSound.isPlaying){
                coinPickSound.Stop();
            }
            coinPickSound.Play();
            //increase score 
        }
    }

}
