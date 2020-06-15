using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
   public GameObject planta;
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
                Instantiate(planta);

                yield return new WaitForSeconds(Tiempo);
            }
        }

        
    
}
