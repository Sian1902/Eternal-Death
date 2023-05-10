using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpforce;
    BoxCollider2D bc;
    float direction;
    Rigidbody2D rgd;
    Animator anim;
    [SerializeField] LayerMask GroundLayer;
    [SerializeField] GameObject RespawnPoint;
    [SerializeField] GameObject deadplayer;
  public int lives;
    [SerializeField] CameraShake cm;
    private void Start()
    {
        rgd= GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
        bc= GetComponent<BoxCollider2D>();
        
    }
    private void Update()
    {
        direction = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && Grounded())
        {
            jump();
        }
        run();
        animate();
        Die();
        
    }
    private void run()
    {
       rgd.velocity=new Vector2(speed*direction, rgd.velocity.y);
        
    }
    private void jump()
    {
        rgd.velocity = new Vector2(rgd.velocity.x, jumpforce);
    }
    bool Grounded()
    {
        return Physics2D.BoxCast(bc.bounds.center, bc.bounds.size, 0f, Vector2.down, 0.1f, GroundLayer);
    }
    private void animate()
    {
        if (direction > 0 )
        {
            anim.SetInteger("state", 1);
            transform.localScale = new Vector2(1, 1);
        }
        else if (direction <0)
        {
            anim.SetInteger("state", 1);
            transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            anim.SetInteger("state", 0);
        }
        if(!Grounded()&&rgd.velocity.y>-0.1f)
        {
            anim.SetInteger("state", 2);

        }
        else if(!Grounded() && rgd.velocity.y < -0.1f)
        {
            anim.SetInteger("state", 3);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            cm.Shack();
            Instantiate(deadplayer, gameObject.transform.position, Quaternion.identity);
            lives--;
            gameObject.transform.position = RespawnPoint.transform.position;  
        }
    }
    void Die()
    {
        if(lives == 0)
        {
            StartCoroutine(LoadLevel());
            transform.localScale = new Vector3(0, 0, 0);
        }
    }
    IEnumerator LoadLevel()
    {
        
        yield return new WaitForSecondsRealtime(0.6f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}


