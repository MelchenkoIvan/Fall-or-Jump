using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class TextFaid : MonoBehaviour
{
    private Text text;
    private Outline Line;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        Line = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, Mathf.PingPong(Time.time / 2.5f, 1.0f));
        Line.effectColor = new Color(Line.effectColor.r, Line.effectColor.g, Line.effectColor.b, text.color.a - 0.3f);
    }
}
