using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZumbiEnemy : MonoBehaviour
{
    private Vector2 direcaoAndar;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveDirection();
    }

    public void SetdirecaoAndar(Vector2 direction)
    {
        direcaoAndar = direction;
    }

    public void MoveDirection()
    {
        transform.Translate(direcaoAndar * Time.deltaTime);
    }
}
