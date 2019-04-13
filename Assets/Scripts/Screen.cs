using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{

    /// <summary>
    /// A number between 1-8.
    /// Each screen object corresponds to one
    /// display, with a maximum of 8
    /// </summary>
    private int targetDisplay;

    /// <summary>
    /// What type of content is on this screen?
    /// </summary>
    private ContentType contentType;

    /// <summary>
    /// In order to initialize the screen object,
    /// Setup() must be called.
    /// </summary>
    public void Setup(int targetDisplay, ContentType contentType)
    {
        this.targetDisplay = targetDisplay;
        this.contentType = contentType;
    }
}
