using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour
{
    public string Name { get; private set;}
    public double Health { get; private set; }
    public double MaxHealth { get; private set; }
    public double Energy { get; private set; }
    public double MaxEnergy { get; private set; }

    public IList<Ability> Abilities { get; private set; }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
