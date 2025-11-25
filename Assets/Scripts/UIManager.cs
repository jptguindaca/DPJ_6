using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;



public class UIManager : MonoBehaviour
{

    public TMP_Text Scoretext;

    public TMP_Text Livestext;

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
       
        SetLives(startlives);

        UpdateScoreUI();

        UpdateLivesUI();


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

     public void AddScore(int amount)
    {

        score+=amount;

        

        UpdateScoreUI();

       

    }

    void UpdateScoreUI()
    {
        
       Scoretext.text=score.ToString();

    }

    void SetLives(int newLives)
    {

        lives=newLives;

        UpdateLivesUI();
    }

    void UpdateLivesUI()
    {

        Livestext.text = lives.ToString();

    }
}
