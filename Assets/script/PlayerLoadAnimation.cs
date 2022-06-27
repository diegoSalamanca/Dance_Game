//Developed by: Diego Fabian Salamanca Garcia
//Emial: Diegocolmayor@gmail.com
//Tel: 3508232690

using UnityEngine;

public class PlayerLoadAnimation : MonoBehaviour
{    

    public AnimationData animationData;

    void Start()
    {
        GetComponent<Animator>().SetTrigger(animationData.currentAniamtion);
    }

    
}
