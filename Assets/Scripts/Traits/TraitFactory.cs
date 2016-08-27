using UnityEngine;
using System.Collections.Generic;

public class TraitFactory {
    Dictionary<string, BaseTrait> instantiatedTraits = new Dictionary<string, BaseTrait>();

    enum Traits
    {
        Tiny,
        Small,
        Midsized,
        Large,
        Huge,
        Enormous,
        Strong,
        Weak,
        Quick,
        Slow,
        Aggressive,
        Docile,
        Flying,
        KeenEyes,
        Armored,
        Spikes,
        KeenSmell,
        Horny,
        Horned,
        QuickBreeding,
        SlowBreeding,
        MultiOffspring,
        Loyal,
        Independent,
    }

    enum TraitClass
    {
        Size,
    }

    BaseTrait createLarge()
    {
        if (instantiatedTraits.ContainsKey(Traits.Large.ToString()))
        {
            return instantiatedTraits[Traits.Large.ToString()];
        }
        BaseTrait large = new BaseTrait();
        large.fightScore = 1;
        large.foodScore = 3;
        large.strengthScore = 1;
        large.trackingScore = 0;

        large.inheritanceChance = 0.5f;

        large.name = Traits.Large.ToString();
        large.type = Traits.Large.ToString();
        large.traitClass = TraitClass.Size.ToString();

        large.linkageMap.Add(Traits.Strong.ToString(), 0.2f);
        large.linkageMap.Add(Traits.Weak.ToString(), -0.2f);
        large.linkageMap.Add(Traits.SlowBreeding.ToString(), 0.2f);
        large.linkageMap.Add(Traits.Slow.ToString(), 0.2f);
        return large;
    }
}
