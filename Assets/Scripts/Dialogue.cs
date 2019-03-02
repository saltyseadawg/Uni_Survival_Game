using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * A serializable Dialogue class containing all the sentence strings
 * required for the conversation.
 */

[System.Serializable]
public class Dialogue
{
    public string name;
    [TextArea(3, 10)]
    public string[] sentences;
}
