using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Slider healthBar;

    public TMP_Text healthText;

    public int health = 100;

    public int maxHealth = 0;

    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health + " / " + health;
        healthBar.value = (float)health / (float)maxHealth;
        
        if (health <= 0)
        {
            healthBar.gameObject.SetActive(false);
            animator.SetBool("isDead" , true);

            Destroy(gameObject, 7f);
        }
    }

    //to be able to take dammage
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Hit")
        {
            health = health - 25;
        }
    }
}
