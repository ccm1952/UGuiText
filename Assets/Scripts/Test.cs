using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public GText text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            text.text = "<a type=emoji>AB</a>\n<a type=emoji>AB</a>1\n<a type=emoji>AB</a>\n<a type=emoji>AB</a><a type=emoji>AB</a><a type=emoji>AB</a>";
            LayoutRebuilder.ForceRebuildLayoutImmediate(text.transform as RectTransform);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            text.text =
                "";
            LayoutRebuilder.ForceRebuildLayoutImmediate(text.transform as RectTransform);
        }
    }
}
