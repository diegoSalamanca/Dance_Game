//Prueba presentada por: Diego Fabian Salamanca Garcia
//Emial: Diegocolmayor@gmail.com
//Tel: 3508232690 / 3017337051
//Descripción: Este código crea un scriptable object para el manejo de los estados de la animación del baile entre escenas


using UnityEngine;

[CreateAssetMenu(fileName = "AnimationData", menuName = "ScriptableObjects/AniamationData", order = 1)]

public class AnimationData : ScriptableObject
{
    public string currentAniamtion;
    public int currentSounnd;
}
