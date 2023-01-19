using System;
using UnityEngine;
using TMPro;

class HealthObject : MonoBehaviour
{
    [SerializeField] TMP_Text textComponent;
    [SerializeField] int maxHealth = 100;

    [SerializeField] GameObject objectToTurnOnWhenDie;      //amikor kipurcan akkor ez l�p majd �rv�nybe - game over

    [SerializeField] Color maxHealthColor;
    [SerializeField] Color zeroHealthColor;


    int currentHealth;               // oszt�ly szint� v�ltoz�


    private void Start()
    {
        currentHealth = maxHealth;

        UpdateText();
    }

    void UpdateText()
    {
        textComponent.text = "Health: " + currentHealth;

        float healthRate = (float)currentHealth / maxHealth;
        textComponent.color = Color.Lerp(zeroHealthColor, maxHealthColor, healthRate);
    }

    public void Kill()                          // met�dust hozunk l�tre
    {
        currentHealth = 0;
        UpdateText();
        TestDeath();
    }

    public bool IsDead()
    {
        return currentHealth <= 0;
    }

    public void Damage(int damage)
    {

        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateText();
        TestDeath();
    }


    // k�l�n met�dus when die

    void TestDeath()
    {
        if (IsDead())
        {
            objectToTurnOnWhenDie.SetActive(true);
            // objectToTurnOnWhenDie?.SetActive(true);     ha objectToTurnOnWhenDie �rt�ke nulla vagyis nincs bek�tve semmi, akkor nincs teend�je, ha van valami akkor pedig a setactive val�sul meg. ez hiba kik�sz�b�l�s
        }
    }



}
