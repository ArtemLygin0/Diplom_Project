using System;
using UnityEngine;

public class HowEnumWork : MonoBehaviour
{
    public float damage;
    public DamageType damageType = 0;

    private void Awake()
    {
        var weakness = DamageType.Crushing;
        var damageType = DamageType.Physical;
        //if (damageType.HasFlag(weakness))
        if ((damageType & weakness) > 0)
        {
            Debug.Log("Double damage!");
        }
    }
}
// Не больше 32 бинарных
[Flags]
public enum DamageType
{
    Piercing = 1 << 0,  //00001
    Slashing = 1 << 1,  //00010
    Crushing = 1 << 2,  //00100
    Ice = 1 << 3,       //01000
    Fire = 1 << 4,      //10000
    Physical = Piercing | Slashing | Crushing, //00111
    Magical = Ice | Slashing | Crushing, //01110
}