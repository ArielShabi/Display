using TMPro;
using UnityEngine;

public class QuestionUi : MonoBehaviour
{
    private TextMeshProUGUI _text;
    
    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();        
    }

    public void SetQuestionText(string newText)
    {
        _text.text = newText;
    }
}
