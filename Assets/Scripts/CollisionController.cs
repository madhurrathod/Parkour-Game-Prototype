using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip coinCollect;
    // public AudioClip respawn;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Finish"){
            SceneManager.LoadScene("Level2");
        }
        if(other.gameObject.tag == "Respawn"){
            SceneManager.LoadScene("Level1");
        }
        if(other.gameObject.tag == "coin"){
            Destroy(other.gameObject);
            Audio.PlayOneShot(coinCollect);
        }
    }
}
