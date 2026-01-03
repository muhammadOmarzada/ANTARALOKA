using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    public TMP_Text healthText;
    public Animator healthTextAnim;

    public Vector2 respawnPosition; // ← DITAMBAHKAN

    private void Start()
    {
        healthText.text = currentHealth + "/" + maxHealth;
    }

    public void changeHealth(int amount)
    {
        currentHealth += amount;
        healthTextAnim.Play("textUpdate");
        healthText.text = currentHealth + "/" + maxHealth;

        if(currentHealth <= 0)
        {
            currentHealth = maxHealth;
            transform.position = respawnPosition; // ← DIGANTI
            healthText.text = currentHealth + "/" + maxHealth;
        }
    }
}
