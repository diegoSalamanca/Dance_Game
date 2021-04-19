//Prueba presentada por: Diego Fabian Salamanca Garcia para Life Is the Game
//Emial: Diegocolmayor@gmail.com
//Tel: 3508232690 / 3017337051
//Descripción: Esta clase reproduce la animación guardada en el scriptable object en la escena 2
using UnityEngine;

public class PlayerLoadAnimation : MonoBehaviour
{    

    public AnimationData animationData;

    void Start()
    {
        GetComponent<Animator>().SetTrigger(animationData.currentAniamtion);
    }

    
}
