using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] SpriteRenderer bgr;
    [SerializeField] float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgr.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
