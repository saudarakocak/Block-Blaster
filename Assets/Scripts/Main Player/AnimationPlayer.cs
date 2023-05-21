using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    public Animator animasi;

    public void TouchEnemyAnimation()
    {
        animasi.SetBool("TouchEnemy", true);
    }
    public void TouchItemAnimation()
    {
        animasi.SetBool("TouchItem", true);
    }

    void UntouchEnemyAnimation()
    {
        animasi.SetBool("TouchEnemy", false);
    }
    void UntouchItemAnimation()
    {
        animasi.SetBool("TouchItem", false);
    }

    public void StopRotateAnimation()
    {
        animasi.SetBool("Rotate", true);
    }
    void UnStopRotateAnimation()
    {
        animasi.SetBool("Rotate", false);
    }

    public void Portal()
    {
        animasi.SetBool("Portal", true);
    }
    public void UnPortal()
    {
        animasi.SetBool("Portal", false);
    }
}
