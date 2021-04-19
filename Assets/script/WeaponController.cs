//Prueba presentada por: Diego Fabian Salamanca Garcia para Life Is the Game
//Emial: Diegocolmayor@gmail.com
//Tel: 3508232690 / 3017337051
//Descripción: Esta clase controla las armas y sus disparos



using UnityEngine;


public class WeaponController : MonoBehaviour
{
    public Material[] materials;

    public MeshRenderer meshRenderer;

    public Animator animator;

    int type = 0;    

    SoundManager soundManager;     

    public ParticleSystem[] particlesShoots;   

    public GameObject shootButton;

    public WeaponsData weaponsData;



    void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();

        shootButton.SetActive(false);
    }

    private void Update()
    {
        particlesShoots[0].startLifetime = weaponsData.parabolicDistance;
        particlesShoots[1].startSpeed = weaponsData.magneticForce;
        particlesShoots[2].startSize = weaponsData.laserPower;
    }

    public void EnableShootButton()
    {
        shootButton.SetActive(true);
    }

    public void DisableShootButton()
    {
        shootButton.SetActive(false);
    }


    public void SetWeapon(int type)
    {
        soundManager.StopAll();
        animator.SetTrigger("change");       
        this.type = type;
    }
    

    public void ChangeWeapon()
    {
        soundManager.PlayShort(0);
        meshRenderer.material = materials[type];        
    }
    

    public void PlayShoot()
    {
        particlesShoots[type].Play();

        switch (type)
        {
            default:

                break;
            case 0:
                animator.SetTrigger("parabol");
                soundManager.PlayLong(7);
                break;

            case 1:
                soundManager.PlayLong(8);
                break;

            case 2:
                soundManager.PlayShort(1);
                break;
        }

        
        
    }

    public void StopShoot()
    {
        

        switch (type)
        {
            default:

                break;
            case 0:
                animator.SetTrigger("endParabol");
                particlesShoots[type].Stop();
                soundManager.StopAll();
                break;

            case 1:
                particlesShoots[type].Stop();
                soundManager.StopAll();
                break;
            
        }

        
    }





}
