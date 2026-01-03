using UnityEngine;

public class Enemy_Combat : MonoBehaviour
{

    public int damage = 1;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().changeHealth(-damage);
        }
        
    }
}
