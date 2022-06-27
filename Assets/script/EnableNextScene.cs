//Developed by: Diego Fabian Salamanca Garcia
//Emial: Diegocolmayor@gmail.com
//Tel: 3508232690

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
