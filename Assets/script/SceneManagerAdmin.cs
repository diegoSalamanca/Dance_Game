//Prueba presentada por: Diego Fabian Salamanca Garcia para Life Is the Game
//Emial: Diegocolmayor@gmail.com
//Tel: 3508232690 / 3017337051
//Descripción: Esta clase administra el cambio entre escenas

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerAdmin : MonoBehaviour
{    
    public void GoToScene(string name)
    {
        SceneManager.LoadScene(name);
    }

}
