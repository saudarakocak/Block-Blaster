using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Animator cameraAnimasi;


    public void Shaky()
    {
        cameraAnimasi.SetBool("Shaky", true);
    }
    public void Unshaky()
    {
        cameraAnimasi.SetBool("Shaky", false);
    }

    public void SlowShaky()
    {
        cameraAnimasi.SetBool("SlowShaky", true);
    }
    public void UnSlowShaky()
    {
        cameraAnimasi.SetBool("SlowShaky", false);
    }
}
