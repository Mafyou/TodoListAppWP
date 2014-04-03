using System;
using System.Collections.Generic;
using MyTodoList.WP.Model;

namespace MyTodoList.WP.Data
{
    public class BuildDataMoq
    {
        private const int MAX_ITEMS = 20;
        public List<TodoItem> GetItems()
        {

            List<TodoItem> lst = new List<TodoItem>(MAX_ITEMS);
            for (int i = 1; i < MAX_ITEMS; i++)
            {
                lst.Add(new TodoItem
                {
                    Id = Guid.NewGuid(),
                    Title = "My Todo Next Thing " + i,
                    Description = "My Description of todo next thing " + i,
                    Coordinates = new List<CoordinateItem>
                    {
                        new CoordinateItem
                        {
                            X = 50 % i,
                            Y = 100 % i
                        },
                        new CoordinateItem
                        {
                            X = 75 % i,
                            Y = 200 % i
                        },
                        new CoordinateItem
                        {
                            X = 100 % i,
                            Y = 300 % i
                        }
                    }
                });
            }
            return lst;
        }
    }
}
