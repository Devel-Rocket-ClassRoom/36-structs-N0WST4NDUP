using System;

RecipeCard recipe = new(
    "토마토 파스타", 2,
    new Ingredient[4]
    {
        new("스파게티면", 200, "g"),
        new("토마토소스", 150, "ml"),
        new("양파", 1, "개"),
        new("마늘", 3, "쪽")
    });
recipe.PrintRecipe();

recipe = recipe.ScaleRecipe(4);
recipe.PrintRecipe();

recipe = recipe.ScaleRecipe(1);
recipe.PrintRecipe();