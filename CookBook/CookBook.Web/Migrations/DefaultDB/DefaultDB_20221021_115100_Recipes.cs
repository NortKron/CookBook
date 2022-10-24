using FluentMigrator;
using Serenity.Extensions;
using System;

namespace CookBook.Web.Migrations.DefaultDB
{
    public class DefaultDB_20221021_115100_Recipes : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Recipes", "RecId", s => s
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Date_Added").AsDateTime().NotNullable()
                .WithColumn("Description").AsString().NotNullable()
                .WithColumn("Photo").AsString().NotNullable()

                .WithColumn("IngredientsList1").AsString().NotNullable()
                .WithColumn("IngredientsList1_Name").AsString().NotNullable()
                .WithColumn("IngredientsList2").AsString().Nullable()
                .WithColumn("IngredientsList2_Name").AsString().Nullable()
                .WithColumn("IngredientsList3").AsString().Nullable()
                .WithColumn("IngredientsList3_Name").AsString().Nullable()
                .WithColumn("Cooking").AsString(100).NotNullable());

            Insert.IntoTable("Recipes").Row(new
            {
                Name = "Яблочный пирог",
                Date_Added = DateTime.Today,
                Description = "Старинный и опробованный всеми рецепт. Этот пирог очень нежный и ароматный, имеет действительно настоящий вкус яблочного пирога!",
                Photo = "",
                IngredientsList1 = "",
                IngredientsList1_Name = "Для теста",
                IngredientsList2 = "",
                IngredientsList2_Name = "Для сметанной заливки",
                IngredientsList3 = "",
                IngredientsList3_Name = "Для начинки",
                Cooking = ""
            });
        }
    }
}
