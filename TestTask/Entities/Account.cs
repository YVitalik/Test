﻿namespace TestTask.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Incident? Incident { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
