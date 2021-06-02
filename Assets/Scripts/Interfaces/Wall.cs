using UnityEngine;

public class Wall : MonoBehaviour, IBreakable
{
    public float Health { get; set; } = 100;

    public void Break(float health)
    {
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void Damage(float damage, int resist)
    {
        Health -= damage / resist;
        Break(Health);
    }
}
