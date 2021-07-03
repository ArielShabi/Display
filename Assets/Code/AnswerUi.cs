using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AnswerUi : MonoBehaviour
{
    private Image imagedAnswer;
    void Start()
    {
        imagedAnswer = GetComponentsInChildren<Image>().First(image => image.gameObject != gameObject);
    }

    public void SetAnswerImage(Sprite newImage)
    {
        imagedAnswer.sprite = newImage;
    }
}
