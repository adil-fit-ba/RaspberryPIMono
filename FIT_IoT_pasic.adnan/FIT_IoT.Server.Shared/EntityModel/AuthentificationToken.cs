﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIT_IoT.Server.Shared.EntityModel
{
    public class AuthentificationToken
    {
        public int Id { get; set; }

        public string authToken { get; set; }
        public string deviceCpuID { get; set; }
        public string deviceHddID { get; set; }
        public string deviceMotherBoardID { get; set; }

        public DateTime DateCreated { get; set; }
        [ForeignKey(nameof(Korisnik))]
        public int? KorisnikID { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
