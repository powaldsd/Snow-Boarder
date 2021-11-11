using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] int maxSceneIndex = 1;
    [SerializeField] float waitTime;
    [SerializeField] ParticleSystem ps;
    [SerializeField] TextMeshProUGUI text;
    void Awake(){
        text = GetComponent<TextMeshProUGUI>();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        ps = FindObjectOfType<ParticleSystem>();
        bool finished = false;
        if (other.CompareTag("Player") && !finished)
        {
            text.enabled = true;
            if(!ps.isPlaying)
                ps.Play();
            Invoke("Reloader", waitTime);
        }
        finished = true;
    }
    void Reloader()
    {
        int curIndex = SceneManager.GetActiveScene().buildIndex;
        if (SceneManager.GetActiveScene().buildIndex == maxSceneIndex)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            curIndex++;
            SceneManager.LoadScene(curIndex);
        }
        text.enabled = false;
    }
}
