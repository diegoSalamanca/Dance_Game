//Developed by: Diego Fabian Salamanca Garcia
//Emial: Diegocolmayor@gmail.com
//Tel: 3508232690

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerAdmin : MonoBehaviour
{    
    public void GoToScene(string name)
    {
        SceneManager.LoadScene(name);
    }

}
