using UnityEngine;

public class playermovement : MonoBehaviour
{

    //reference to rigid body
    public Rigidbody rb;
   
    public float forwardforce = 2000f;
    public float sidewiseforce =500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        //add forward force
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewiseforce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if( Input.GetKey("a"))
        {
            rb.AddForce(-sidewiseforce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y< -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
