using System;

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        Console.WriteLine(
            $"[{Name}] ({Servings}인분)" + "\n" +
            "재료:"
        );
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Console.WriteLine($"- {Ingredients[i].Name}: {Ingredients[i].Amount}{Ingredients[i].Unit}");
        }
    }

    public RecipeCard ScaleRecipe(int newServings)
    {
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Ingredients[i].Amount *= 1.0 * newServings / Servings;
        }
        return new RecipeCard(Name, newServings, Ingredients);
    }
}