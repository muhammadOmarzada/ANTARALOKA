using UnityEngine;

public class Player_Senter : MonoBehaviour
{
    public Animator anim;
    public Transform attackPoint;
    public float weaponRange = 1;
    public LayerMask enemyLayer;
    public int damage = 1;

    public void Senter()
    {
        anim.SetBool("isSenter", true);
    }

    public void finishSenter()
    {
     anim.SetBool("isSenter", false);  
     
     Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPoint.position, weaponRange, enemyLayer);
     if(enemies.Length > 0)
        {
            enemies[0].GetComponent<Enemy_Health>().ChangeHealth(-damage);
        }
        }
}

