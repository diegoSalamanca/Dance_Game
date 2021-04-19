//Prueba presentada por: Diego Fabian Salamanca Garcia
//Emial: Diegocolmayor@gmail.com
//Tel: 3508232690 / 3017337051
//Descripción: Este código crea un scriptable object para el manejo de las propiedades de las armas

using UnityEngine;

[CreateAssetMenu(fileName = "WeaponsData", menuName = "ScriptableObjects/WeaponsData", order = 1)]
public class WeaponsData : ScriptableObject
{
    [Range(1, 6)]
    public float parabolicDistance;
    [Range(0, 1)]
    public float magneticForce;
    [Range(0.1f, 0.5f)]
    public float laserPower;
}
