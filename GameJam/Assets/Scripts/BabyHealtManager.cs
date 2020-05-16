using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyHealtManager : MonoBehaviour
{

    public int Health;
    private int CurrentHealth;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void HurtBaby(int damage)

    {
        CurrentHealth -= damage;
        Debug.Log(CurrentHealth);
    }
}
