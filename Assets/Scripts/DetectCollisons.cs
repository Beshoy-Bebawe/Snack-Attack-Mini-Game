using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisons : MonoBehaviour
{

     public int scoreToAdd = 0; 
 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Player"))
        {
           
            PlayerController pc = other.GetComponent<PlayerController>();
            pc.score += scoreToAdd;
            Debug.Log(pc.score);
            Destroy(gameObject);
        }else
        {
            Destroy(gameObject);
        }

    }

}
