using SashimisBackending.Datamodels;

namespace SashimisBackending.Controllers
{
    public class SushiController
    {
        public const string TABLE_NAME = "Sushi";

        public void CreateAndSave(string name, string description, float cost)
        {
            string id = DatabaseFirebaseImpl.GetIdForNewEntry(TABLE_NAME);
            Sushi sushi = new Sushi(id, name, description, cost);

            DatabaseFirebaseImpl.SetData(TABLE_NAME, sushi.Id, sushi);

            // Save on DataManager...
        }
    }
}


