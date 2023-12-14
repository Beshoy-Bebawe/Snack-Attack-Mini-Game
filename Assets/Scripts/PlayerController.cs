using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{  
    public float speed = 20;
    
    public float horizontalInput;
    public float verticalInput; 
    public int score = 0;
    public AudioSource playerAudio;
    public  ParticleSystem explosionParticle;
    public AudioClip blipSound;
    public AudioClip boomSound;
    public ParticleSystem fireworkParticle;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
    
     
     if (transform.position.x < -6){
        transform.position = new Vector3(-6, transform.position.y, transform.position.z);
      }
      
      if (transform.position.x > 2)
      {
        transform.position = new Vector3(2, transform.position.y, transform.position.z);
      }
        if (transform.position.z < -6){
        transform.position = new Vector3(transform.position.x, transform.position.y, -6);
      }
      
      if (transform.position.z > 2)
      {
        transform.position = new Vector3(transform.position.x, transform.position.y, 2);
      }

    
    }
    void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Bomb"))
      {
         explosionParticle.Play();
         playerAudio.PlayOneShot(blipSound , 1.0f);

      }

        else if (other.gameObject.CompareTag("Money"))
        {
          fireworkParticle.Play();
          playerAudio.PlayOneShot(boomSound, 1.0f);
          

        }

    } 
}
