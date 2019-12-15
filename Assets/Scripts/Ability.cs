using UnityEngine;
using System.Collections;

public abstract class Ability : MonoBehaviour
{
    public string Name { get; private set; }
    public bool Learned { get; private set; }

    public void Learn()
    {
        if (Learned)
        {
            throw new StateException($"");
        }
    }

    public abstract void Use();
}
