using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grafics : MonoBehaviour
{
    public void lowgrafic()
    {
        QualitySettings.SetQualityLevel(1);
    }

    public void mediumgrafic()
    {
        QualitySettings.SetQualityLevel(3);
    }
    public void highgrafic()
    {
        QualitySettings.SetQualityLevel(6);
    }
}
