//Prueba presentada por: Diego Fabian Salamanca Garcia para Life Is the Game
//Emial: Diegocolmayor@gmail.com
//Tel: 3508232690 / 3017337051
//Descripción: Este código controla la repdrodción de las animaciones de baile

using UnityEngine;

public class DanceManager : MonoBehaviour
{
    public Animator animator;

    public AnimationData animationData;

    public void SetAnimation(string name)
    {
        animator.SetTrigger(name);
        animationData.currentAniamtion = name;
    }

}
