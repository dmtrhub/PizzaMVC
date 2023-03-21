using PizzaLibrary.DataAcess;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.BusinessLogic
{
    public static class PizzaProcessor
    {
        public static int CreatePizza(int pizzaId, string pizzaName, int pizzaSize, int pizzaPrice)
        {
            PizzaModel data = new PizzaModel
            {
                PizzaID = pizzaId,
                PizzaName = pizzaName,
                PizzaSize = pizzaSize,
                PizzaPrice = pizzaPrice
            };

            string sql = @"insert into dbo.Pizza (PizzaID, PizzaName, PizzaSize, PizzaPrice)
                            values (@PizzaID, @PizzaName, @PizzaSize, @PizzaPrice);";

            return SqlDataAcess.SaveData(sql, data);
        }

        public static List<PizzaModel> LoadPizza()
        {
            string sql = @"select Id, PizzaID, PizzaName, PizzaSize, PizzaPrice 
                            from dbo.Pizza;";

            return SqlDataAcess.LoadData<PizzaModel>(sql);
        }
    }
}
