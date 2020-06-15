using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse_2d : MonoBehaviour
{
    public float impulseForce = 10.0f;
    public GameObject planta;
    
    // Start is called before the first frame update
    
    void Start()
    {

        
        StartCoroutine(salto());
    }

    // Update is called once per frame
    void Update()
    {     
    
    
        
    }


    IEnumerator salto() {
            

            while(true){

                
                GetComponent <Rigidbody2D>().AddForce(Vector2.up * impulseForce,ForceMode2D.Impulse );
                yield return new WaitForSeconds(2.0f);
                Destroy (planta);
                
                


                

            }
        
        

    }
}