﻿using Marciixvii.EFR.App.Models.Entities;
using System.Threading.Tasks;

namespace Marciixvii.EFR.App.Contracts {
    public interface IUtilisateurService : ICrud<Utilisateur> {
        Task<Utilisateur> Login(string username, string password);
        Task<bool> IsUsernameOrEmailExists(string username, string email);
        Task<bool> ChangePassword(int id, string password);
    }
}
