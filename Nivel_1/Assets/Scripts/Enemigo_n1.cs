using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_n1 : MonoBehaviour
{
      public GameObject planta;

      public float jumpvalue;
      public float forcevalue;

      private Rigidbody rigidbody;
    public float firerate= 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(throwplanta());
    }

    // Update is called once per frame
    void Update()
    {    
        rigidbody.AddForce(Vector3.up*jumpvalue, ForceMode.Impulse);

    
        
        }

        IEnumerator throwplanta() {
            yield return new WaitForSeconds(1.0f);
            while(true){
                Instantiate(planta,transform.position,Random.rotation);

                yield return new WaitForSeconds(firerate);
            }
        }
    
}
