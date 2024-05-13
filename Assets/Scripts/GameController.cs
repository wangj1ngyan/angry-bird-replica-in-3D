using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject passPanel;
    public GameObject failPanel;
    public PigHealth pigHealth;
    public int totalBirds = 3;
    private int birdsLaunched = 0;
    void Start()
    {
        birdsLaunched++;
        CheckGameOver();
        passPanel.SetActive(false); 
        failPanel.SetActive(false); 
    }

    public void CheckGameOver()
    {
        if (pigHealth.currentHealth <= 0)
        {
            // Pig is dead, show "Pass" panel
            passPanel.SetActive(true);
        }
        else if (birdsLaunched >= totalBirds)
        {
            // All birds are used and pig is still alive
            failPanel.SetActive(true);
        }
    }
    
    public void ResetGame()
    {
        birdsLaunched = 0;
        pigHealth.ResetHealth(); // You need to create this method in PigHealth
        passPanel.SetActive(false);
        failPanel.SetActive(false);
    }
}
