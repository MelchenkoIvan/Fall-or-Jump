using UnityEngine;

public class JumpButton : MonoBehaviour
{
    private float startTime;
    public GameObject player;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
   
    public LayerMask groundLayer;
    public bool isTouchingGround;
    public AudioSource jumpEffect;
    //public float speed = 20f;


    void OnMouseDown()
    {
        if (Player.lose == false)
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);


        if (Player.lose == false && isTouchingGround)
            jumpEffect.Play();
        
           

        if (isTouchingGround)
        player.GetComponent<Rigidbody2D>().AddForce(player.transform.up * 200f);
        //player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.GetComponent<Rigidbody2D>().velocity.x , 100f);

    }
    void OnMouseUp()
    {
        if (Player.lose == false)
        {
            transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);

          
        }
       

    }
    private void Update()
    {
        if(Player.lose == false)
        { 
            isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
         
        }
       

         if(Player.lose == true)
         {
            Destroy(gameObject);
  
         }
    }
}
    

       
