using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Punto4.Models
{
    public class UserTask
    {
        public int Id { get; }
        public string Name { get; private set; }
        public bool IsCompleted { get; private set; }

        public UserTask(int id, string name)
        {
            Id = id;
            Name = name;
            IsCompleted = false;
        }

        public void Rename(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }
            Name = newName;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
    }
}
