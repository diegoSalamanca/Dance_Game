//Developed by: Diego Fabian Salamanca Garcia
//Emial: Diegocolmayor@gmail.com
//Tel: 3508232690

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
