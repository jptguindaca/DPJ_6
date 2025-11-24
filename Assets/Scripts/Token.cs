using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

[RequireComponent(typeof(Collider))]

public class Token : MonoBehaviour
{
    

    public int value;
    public AudioClip pickupsfx;
    private AudioSource audioSource;
    private Collider token;

    private void Awake()
    {
      token = GetComponent<Collider>();

        if(token != null && token.isTrigger==true)
        {

               

        }


      audioSource = gameObject.AddComponent<AudioSource>();

        if(audioSource.enabled == true)
        {

           


        }




    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") == false)
        {

            if (UIManager.Instance != null)
            {
                UIManager.Instance.score += 0;
            }


            if (pickupsfx != null)
            {
                audioSource.Play();
            }






        }


    }
}
