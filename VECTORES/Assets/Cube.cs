using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Vector3 velocity= new Vector3(-5,5,0);
    Vector3 acceleration= new Vector3(0,-9.8f,0);

    void Start()
    {
         
    }

   
    void Update()
    {
    
         transform.position+=velocity*Time.deltaTime;
         velocity+=acceleration*Time.deltaTime;
         if(transform.position.y<-5){
            Debug.Log("llego al piso");
            velocity.y*=-1;
         }
         if(transform.position.x<-5)
         {
             velocity.x*=-1;
         }
         else{
             if(transform.position.x>5)
             {
                 velocity.x*=-1;
             }
         }
    }
}
