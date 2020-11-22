namespace Interfaces
{
    public class PhysicalExercice : IExercises
    {
        public string Title { get; set; }

        public bool IsExCompleted { get; private set; }

        public void AddExercice(ClientModel client)
        {
            if(!IsExCompleted)
            {
                System.Console.WriteLine($"Exercice: { Title } - has been added to {client.FirstName }'s program in { client.City }");
                IsExCompleted = true; 
            }
        }
    }
}