﻿namespace Vozes_Unidas.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string categoria {  get; set; }
        public string imagem { get; set; }
        public DateOnly publicacao { get; set; }
        public int UserId { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
