using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int IntrudersLost = 0;
    public int IntrudersCaptured = 0;

    public Text LostText;
    public Text CapturedText;

    [ContextMenu("Loss 1")]
    public void markLossOne()
    {
        IntrudersLost++;
        LostText.text = "Adventurers Who Reached the Goal: " + IntrudersLost.ToString();
    }

    [ContextMenu("Capture 1")]
    public void markCaptureOne()
    {
        IntrudersCaptured++;
        CapturedText.text = "Adventurers Lost: " + IntrudersCaptured.ToString();
    }

    [ContextMenu("Loss 5")]
    public void markLossFive()
    {
        IntrudersLost +=5;
        LostText.text = "Adventurers Who Reached the Goal: " + IntrudersLost.ToString();
    }

    [ContextMenu("Capture 5")]
    public void markCaptureFive()
    {
        IntrudersCaptured +=5;
        CapturedText.text = "Adventurers Lost: " + IntrudersCaptured.ToString();
    }
}
