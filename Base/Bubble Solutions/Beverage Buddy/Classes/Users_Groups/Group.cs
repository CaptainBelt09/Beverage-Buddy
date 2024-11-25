using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Buddy.Classes.Users_Groups
{
    //Later make Thread safe using concurrent dictionary.
    //Primative constructor.
    public class Group
        (
        int id,
        string name,
        string description,
        int level,
        Permission[] permissions,
        User[] members,
        bool canBeModified,
        bool canBeDeleted,
        DateTime[] lastModified,
        DateTime dateCreated,
        int createdBy,
        int createdByName
        )
    {
       private int id = id;
       private string name = name;
       private string description = description;
       private int level = level;
       private Permission [] permissions = permissions;
       private User[] members = members; 
       private bool canBeModified = canBeModified;
       private bool canBeDeleted = canBeDeleted;
       private DateTime[] lastModified = lastModified;
       private DateTime dateCreated = dateCreated;
       private int createdBy = createdBy;
       private int createdByName = createdByName;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Level { get => level; set => level = value; }
        public Permission[] Permissions { get => permissions; set => permissions = value; }
        public User[] Members { get => members; set => members = value; }
        public bool CanBeModified { get => canBeModified; set => canBeModified = value; }
        public bool CanBeDeleted { get => canBeDeleted; set => canBeDeleted = value; }
        public DateTime[] LastModified { get => lastModified; set => lastModified = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public int CreatedBy { get => createdBy; set => createdBy = value; }
        public int CreatedByName { get => createdByName; set => createdByName = value; }
    }
}
