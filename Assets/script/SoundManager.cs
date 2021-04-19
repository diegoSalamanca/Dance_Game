//Prueba presentada por: Diego Fabian Salamanca Garcia para Life Is the Game
//Emial: Diegocolmayor@gmail.com
//Tel: 3508232690 / 3017337051
//Descripción: Esta clase administra los sonidos

using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    
    public AnimationData animationData;

    public AudioClip[] longAudioClips;

    public AudioClip[] shortAudioClips;

    public AudioSource audioSourceShort;

    public AudioSource audioSourceLong;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name.Equals("Scene_1"))
        {
            PlayLong(0);
        }
        else 
        {
            PlayLong(animationData.currentSounnd);
        }
    }

    public void PlayLong(int index)
    {
        audioSourceLong.clip = longAudioClips[index];
        animationData.currentSounnd = index;
        audioSourceLong.Play();
    }

    public void PlayShort(int index)
    {
        audioSourceLong.PlayOneShot(shortAudioClips[index]);
        animationData.currentSounnd = index;
    }

    public void StopAll()
    {
        audioSourceLong.Stop();
        audioSourceShort.Stop();
    }


}
