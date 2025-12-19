using UnityEngine;

public class BallSoundEffects : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip hitPlayerSfx;
    public AudioClip hitBrickSfx;
    public AudioClip hitGroundSfx;
    public AudioClip hitWallSfx;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {            
            audioSource.PlayOneShot(hitPlayerSfx);
        }
        else if (collision.collider.CompareTag("Destructible"))
        {            
            audioSource.PlayOneShot(hitBrickSfx);
        }
        else if (collision.collider.CompareTag("Floor"))
        {            
            audioSource.PlayOneShot(hitGroundSfx);
        }
        else if (collision.collider.CompareTag("Wall"))
        {            
            audioSource.PlayOneShot(hitWallSfx);
        }
    }
}
