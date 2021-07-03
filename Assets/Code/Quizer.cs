using System.Collections;
using System.Linq;
using UnityEngine;

using Enum = System.Enum;

public class Quizer : MonoBehaviour
{
    public BottlesInventory _bottlesInventory;
    public AnswerUi[] AnswerUis;
    public QuestionUi QuestionUi;

    private readonly int _numberOfDrinkCaregorie;

    public Quizer()
    {
        _numberOfDrinkCaregorie = Enum.GetNames(typeof(DrinkCategory)).Length;
    }

    private void Start()
    {
        StartCoroutine(LateStart(3));
    }
    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        AskCategoryToBottleQuestion();
    }

    public void AskCategoryToBottleQuestion()
    {
        var category = (DrinkCategory)Random.Range(0, _numberOfDrinkCaregorie);
        var correctBottle = _bottlesInventory.GetRandomBottleByCategory(category);
        var wrongBottles = _bottlesInventory.GetRandomBottlesFromOtherCategory(category);

        AnswerUis[0].SetAnswerImage(correctBottle.Sprite);

        for (int i = 0; i < wrongBottles.Count; i++)
        {
            AnswerUis[i + 1].SetAnswerImage(wrongBottles[i].Sprite);
        }

        QuestionUi.SetQuestionText(category.ToString());
    }
}
