using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_imagen : MonoBehaviour
{

    MeshRenderer _renderer;

    float _scrollingspeedX  =   0.3f;
    Vector2 _currentPos= Vector2.zero;
    private void Awake ()
    {
        _renderer=GetComponent<MeshRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _currentPos.x += _scrollingspeedX * Time.deltaTime;
        _renderer.material.mainTextureOffset = _currentPos; 
    }
}
