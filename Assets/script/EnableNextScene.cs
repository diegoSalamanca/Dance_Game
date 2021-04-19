//Prueba presentada por: Diego Fabian Salamanca Garcia para Life Is the Game
//Emial: Diegocolmayor@gmail.com
//Tel: 3508232690 / 3017337051
//Descripción: Esta clase activa el boton para cambiar de escena luego de seleccionar una animación


using UnityEngine;

public class EnableNextScene : MonoBehaviour
{

    public GameObject NextButon;
    public Animator playerAnimator;

    // Update is called once per frame
    void Update()
    {       

        if (playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            NextButon.SetActive(false);
        }
        else 
        {
            NextButon.SetActive(true);
        }
    }
}
