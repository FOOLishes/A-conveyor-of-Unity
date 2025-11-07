using UnityEngine;
using TMPro;

public class BoxCounter : MonoBehaviour
{
    public TextMeshProUGUI contText;
    public float boxCount = 0;
    public void Addcount()
    {
        boxCount++;
        UpdateText();
    }
    private void UpdateText()
    {
        if( contText != null )
        {
            contText.text = "通过数量：" + boxCount;
        }
    }
}
