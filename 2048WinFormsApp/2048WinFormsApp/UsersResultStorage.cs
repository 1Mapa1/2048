using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048ClassLibrary
{
    public class UsersResultStorage
    {
        static readonly string fileName = "userResult.json";
        public static void Append(User user)
        {
            var userResults = Get();

            userResults.Add(user);

            Save(userResults);
        }

        public static List<User> Get()
        {
            if (!FileProvider.Exists(fileName))
            {
                return new List<User>();
            }
            else
            {
                var value = FileProvider.GetData(fileName);

                var userResults = JsonConvert.DeserializeObject<List<User>>(value);

                return userResults;
            }
        }

        static void Save(List<User> usersResults)
        {
            var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
            FileProvider.Replace(jsonData, fileName);
        }
    }
}
