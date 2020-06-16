using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    Vector3 _movementSpeed = new Vector3(20, 20);
    Vector3 _deltaPos = new Vector3();
    const float MIN_LIM_Y = -20.4f, MAX_LIM_Y=17.3f;
    const float MIN_LIM_X = -34.0f, MAX_LIM_X =34.9f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _deltaPos.x = Input.GetAxis("Horizontal") * _movementSpeed.x;
        _deltaPos.y = Input.GetAxis("Vertical") * _movementSpeed.y;
        _deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x,MIN_LIM_X,MAX_LIM_X),
            Mathf.Clamp(gameObject.transform.position.y,MIN_LIM_Y,MAX_LIM_Y),
            gameObject.transform.position.z);

    }
}
