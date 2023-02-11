using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkManager : MonoBehaviour
{
    public void openLink(string url)
    {
        Application.OpenURL(url);
    }
}
