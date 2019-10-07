﻿using UnityEngine;

public class Mode
{
    public PrimeHand hand;

    public Mode(PrimeHand hand)
    {
        this.hand = hand;
    }

    public virtual void OnTriggeredGrab() { }       //그랩
    public virtual void OnTriggeredRelease() { }    //릴리즈
    public virtual void OnTriggeredPick() { }       //픽
    public virtual void OnTriggeredDrop() { }       //드랍
    public virtual void OnTriggeredClick() { }      //클릭
}

public class EntryMode : Mode
{
    public EntryMode(PrimeHand hand):base(hand)
    {
        this.hand = hand;
    }

    public override void OnTriggeredRelease()
    {
        Debug.Log("EntryMode : Release!@!");
    }

    public override void OnTriggeredGrab()
    {
        Debug.Log("EntryMode : Grab!@!");
    }
}