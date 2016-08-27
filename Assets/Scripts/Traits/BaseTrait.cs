using UnityEngine;
using System.Collections.Generic;

public class BaseTrait
{
    public int fightScore;
    public int strengthScore;
    public int trackingScore;
    public int foodScore;

    public float inheritanceChance;

    public string name;
    public string type;
    public string traitClass;

    public Dictionary<string, float> linkageMap = new Dictionary<string, float>();

    public bool isCompatible(BaseTrait other)
    {
        return !(this.type == other.type || traitClass == other.traitClass);
    }
}
