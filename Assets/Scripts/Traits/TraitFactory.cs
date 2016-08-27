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
        Power,
    }

    BaseTrait createTiny()
    {
        if (instantiatedTraits.ContainsKey(Traits.Tiny.ToString()))
        {
            return instantiatedTraits[Traits.Tiny.ToString()];
        }
        BaseTrait tiny = new BaseTrait();
        tiny.fightScore = -1;
        tiny.foodScore = 0;
        tiny.strengthScore = 0;
        tiny.trackingScore = 0;

        tiny.inheritanceChance = 0.5f;

        tiny.name = Traits.Tiny.ToString();
        tiny.type = Traits.Tiny.ToString();
        tiny.traitClass = TraitClass.Size.ToString();

        tiny.linkageMap.Add(Traits.Strong.ToString(), -0.4f);
        tiny.linkageMap.Add(Traits.Weak.ToString(), 0.4f);
        tiny.linkageMap.Add(Traits.SlowBreeding.ToString(), -0.4f);
        tiny.linkageMap.Add(Traits.Slow.ToString(), -0.4f);
        tiny.linkageMap.Add(Traits.Quick.ToString(), 0.4f);

        instantiatedTraits[Traits.Tiny.ToString()] = tiny;
        return tiny;
    }

    BaseTrait createSmall()
    {
        if (instantiatedTraits.ContainsKey(Traits.Small.ToString()))
        {
            return instantiatedTraits[Traits.Small.ToString()];
        }
        BaseTrait small = new BaseTrait();
        small.fightScore = 0;
        small.foodScore = 1;
        small.strengthScore = 0;
        small.trackingScore = 0;

        small.inheritanceChance = 0.5f;

        small.name = Traits.Small.ToString();
        small.type = Traits.Small.ToString();
        small.traitClass = TraitClass.Size.ToString();

        small.linkageMap.Add(Traits.Strong.ToString(), -0.2f);
        small.linkageMap.Add(Traits.Weak.ToString(), 0.2f);
        small.linkageMap.Add(Traits.SlowBreeding.ToString(), -0.2f);
        small.linkageMap.Add(Traits.Slow.ToString(), -0.2f);
        small.linkageMap.Add(Traits.Quick.ToString(), 0.2f);

        instantiatedTraits[Traits.Small.ToString()] = small;
        return small;
    }

    BaseTrait createMidsized()
    {
        if (instantiatedTraits.ContainsKey(Traits.Midsized.ToString()))
        {
            return instantiatedTraits[Traits.Midsized.ToString()];
        }
        BaseTrait midsized = new BaseTrait();
        midsized.fightScore = 1;
        midsized.foodScore = 2;
        midsized.strengthScore = 0;
        midsized.trackingScore = 0;

        midsized.inheritanceChance = 0.5f;

        midsized.name = Traits.Midsized.ToString();
        midsized.type = Traits.Midsized.ToString();
        midsized.traitClass = TraitClass.Size.ToString();

        instantiatedTraits[Traits.Midsized.ToString()] = midsized;
        return midsized;
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
        large.linkageMap.Add(Traits.Quick.ToString(), -0.2f);

        instantiatedTraits[Traits.Large.ToString()] = large;
        return large;
    }

    BaseTrait createHuge()
    {
        if (instantiatedTraits.ContainsKey(Traits.Huge.ToString()))
        {
            return instantiatedTraits[Traits.Huge.ToString()];
        }
        BaseTrait huge = new BaseTrait();
        huge.fightScore = 2;
        huge.foodScore = 4;
        huge.strengthScore = 2;
        huge.trackingScore = 0;

        huge.inheritanceChance = 0.5f;

        huge.name = Traits.Huge.ToString();
        huge.type = Traits.Huge.ToString();
        huge.traitClass = TraitClass.Size.ToString();

        huge.linkageMap.Add(Traits.Strong.ToString(), 0.4f);
        huge.linkageMap.Add(Traits.Weak.ToString(), -0.4f);
        huge.linkageMap.Add(Traits.SlowBreeding.ToString(), 0.4f);
        huge.linkageMap.Add(Traits.Slow.ToString(), 0.4f);
        huge.linkageMap.Add(Traits.Quick.ToString(), -0.4f);

        instantiatedTraits[Traits.Huge.ToString()] = huge;
        return huge;
    }

    BaseTrait createEnormous()
    {
        if (instantiatedTraits.ContainsKey(Traits.Enormous.ToString()))
        {
            return instantiatedTraits[Traits.Enormous.ToString()];
        }
        BaseTrait enormous = new BaseTrait();
        enormous.fightScore = 2;
        enormous.foodScore = 4;
        enormous.strengthScore = 2;
        enormous.trackingScore = 0;

        enormous.inheritanceChance = 0.5f;

        enormous.name = Traits.Enormous.ToString();
        enormous.type = Traits.Enormous.ToString();
        enormous.traitClass = TraitClass.Size.ToString();

        enormous.linkageMap.Add(Traits.Strong.ToString(), 0.6f);
        enormous.linkageMap.Add(Traits.Weak.ToString(), -0.6f);
        enormous.linkageMap.Add(Traits.SlowBreeding.ToString(), 0.6f);
        enormous.linkageMap.Add(Traits.Slow.ToString(), 0.6f);
        enormous.linkageMap.Add(Traits.Quick.ToString(), -0.6f);

        instantiatedTraits[Traits.Enormous.ToString()] = enormous;
        return enormous;
    }

    BaseTrait createStrong()
    {
        if (instantiatedTraits.ContainsKey(Traits.Strong.ToString()))
        {
            return instantiatedTraits[Traits.Strong.ToString()];
        }
        BaseTrait strong = new BaseTrait();
        strong.fightScore = 1;
        strong.foodScore = 0;
        strong.strengthScore = 2;
        strong.trackingScore = 0;

        strong.inheritanceChance = 0.5f;

        strong.name = Traits.Strong.ToString();
        strong.type = Traits.Strong.ToString();
        strong.traitClass = TraitClass.Power.ToString();

        strong.linkageMap.Add(Traits.SlowBreeding.ToString(), 0.1f);
        strong.linkageMap.Add(Traits.Slow.ToString(), 0.2f);
        strong.linkageMap.Add(Traits.Quick.ToString(), -0.1f);

        instantiatedTraits[Traits.Strong.ToString()] = strong;
        return strong;
    }

    BaseTrait createWeak()
    {
        if (instantiatedTraits.ContainsKey(Traits.Weak.ToString()))
        {
            return instantiatedTraits[Traits.Weak.ToString()];
        }
        BaseTrait weak = new BaseTrait();
        weak.fightScore = 1;
        weak.foodScore = 0;
        weak.strengthScore = 2;
        weak.trackingScore = 0;

        weak.inheritanceChance = 0.5f;

        weak.name = Traits.Weak.ToString();
        weak.type = Traits.Weak.ToString();
        weak.traitClass = TraitClass.Power.ToString();

        weak.linkageMap.Add(Traits.Quick.ToString(), -0.1f);

        instantiatedTraits[Traits.Weak.ToString()] = weak;
        return weak;
    }
}
