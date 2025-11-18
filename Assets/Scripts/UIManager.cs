using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;



public class UIManager : MonoBehaviour
{

    public TMP_Text scoretext;

    public TMP_Text livestext;

    public int startlives = 3;

    public int score = 0;

    private int lives;

    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        

        if (Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;

        lives = startlives;
        AddScore(0);    
        SetLives(startlives);


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

       
    }

    void AddScore(int amount = 5)
    {

        amount += score;

        score = amount;
        UpdateScoreUI();

    }

    void UpdateScoreUI()
    {

       scoretext.text=score.ToString();

    }

    void SetLives(int newLives)
    {

        lives=newLives;

        UpdateLivesUI();
    }

    void UpdateLivesUI()
    {

        livestext.text = lives.ToString();

    }
}
