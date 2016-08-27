using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseTrait
{
    int fightScore;
    int strengthScore;
    int trackingScore;
    int foodScore;

    float inheritanceChance;

    string name;
    string type;
    string traitClass;

    Dictionary<string, float> linkageMap = new Dictionary<string, float>();
}
