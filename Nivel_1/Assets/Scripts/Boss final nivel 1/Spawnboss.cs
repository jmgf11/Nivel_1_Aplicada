using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnboss : MonoBehaviour
{
   public GameObject proyectil;
    public float Tiempo ;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(throwplanta());
    }

    // Update is called once per frame
    void Update()
    {
        
        }

        IEnumerator throwplanta() {
            
            while(true){
                Instantiate(proyectil);

                yield return new WaitForSeconds(Tiempo);
            }
        }

        
    
}