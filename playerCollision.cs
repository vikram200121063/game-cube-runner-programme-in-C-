using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerScript playerscript;
    public Score score;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSource1;
   
   private void OnTriggerEnter(Collider other) {
       if (other.gameObject.tag == "collectables")
       {
           audioSource.Play();
           score.AddScore(1);
           Destroy(other.gameObject);
       }
   }
   private void OnCollisionEnter(Collision other) {
       if (other.gameObject.tag == "Obstacles")
       {
           audioSource1.Play();
           gameController.GameOver();
          playerscript.enabled = false; 
       }
   }
}
