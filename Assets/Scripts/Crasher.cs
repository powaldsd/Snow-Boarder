using System.Xml.Resolvers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crasher : MonoBehaviour
{
    [SerializeField] float waitTime;
    [SerializeField] ParticleSystem ps;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground"))
        {
            if(!ps.isPlaying)
                ps.Play();
            FindObjectOfType<PlayerController>().Disable();
            Invoke("Reloader", waitTime);
        }
    }

    void Reloader()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
