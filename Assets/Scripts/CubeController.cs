using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private AudioClip impactSound;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the cube collided with the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Play the impact sound if both audio source and clip exist
            if (audioSource != null && impactSound != null)
            {
                audioSource.PlayOneShot(impactSound);
            }
        }
    }
}
