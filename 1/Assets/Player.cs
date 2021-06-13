using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
private void PlayerMove(){

}
private void PlayerJump()
{
    if(isJump == false)
    {
        GetCoponent<Animator>().Setbool("Walk", false);
        GetCoponent<Animator>().Setbool("Jump", false);

        Vector2 vector2 = new Vector2(0, JumpForce);
        GetConponent<Rigidbody2D>().AddForce(vector2);
        isJump = true;

    }
}

private void OnCollisionEnter