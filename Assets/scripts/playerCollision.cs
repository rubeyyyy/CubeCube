using UnityEngine;

public class playerCollision: MonoBehaviour
{
    public playermovement movement;
    
    void OnCollisionEnter(Collision collisioninfo)
   {
       if(collisioninfo.collider.tag == "obstacle")
       {
           movement.enabled = false;
           FindObjectOfType<GameManager>().EndGame();
       }
   }
}
