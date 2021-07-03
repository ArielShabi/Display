using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AnswerUi : MonoBehaviour
{
    private Image imagedAnswer;
    public Sprite Test;
    void Start()
    {
        imagedAnswer = GetComponentsInChildren<Image>().First(image => image.gameObject != gameObject);    
    }

    public void UpdateAnswerImage(Sprite newImage)
    {
        imagedAnswer.sprite = newImage;
    }
}
