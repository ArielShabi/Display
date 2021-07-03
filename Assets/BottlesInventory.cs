using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu()]
public class BottlesInventory : ScriptableObject
{
    public BottleInfo[] Bottles;

    public BottleInfo GetRandomBottleByCategory(DrinkCategory drinkCategory)
    {
        var drinkCategoryBottles = Bottles.Where(bottle => bottle.DrinkCategory == drinkCategory).ToList();
        var randomBottle = drinkCategoryBottles.Skip(Random.Range(0, drinkCategoryBottles.Count())).First();

        return randomBottle;
    }

    public List<BottleInfo> GetRandomBottlesFromOtherCategory(DrinkCategory drinkCategory, int bottlesCount = 3)
    {
        var chosenBottles = new List<BottleInfo>();
        var allBottles = Bottles.Where(bottle => bottle.DrinkCategory != drinkCategory).ToList();

        for (int i = 0; i < bottlesCount; i++)
        {
            BottleInfo bottle;

            do
            {
                var randomNumber = Random.Range(0, allBottles.Count());
                bottle = allBottles.Skip(randomNumber).First();
            }
            while (chosenBottles.Contains(bottle));            

            chosenBottles.Add(bottle);
        }

        return chosenBottles;
    }
}
