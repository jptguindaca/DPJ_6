using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

[RequireComponent(typeof(Collider))]
public class Token : MonoBehaviour
{
    public int value;
    public AudioClip pickupSfx;
    private AudioSource audioSource;
    private Collider tokenCollider;

    private void Awake()
    {
        tokenCollider = GetComponent<Collider>();
        if (tokenCollider != null)
        {
            tokenCollider.isTrigger = true;
        }

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {



            UIManager.Instance.AddScore(value);

            if (pickupSfx != null)
            {
                audioSource.PlayOneShot(pickupSfx);
               
                
            }
            Destroy(gameObject,pickupSfx.length);

        }
    }
}
