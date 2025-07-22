using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CONTROLADORA.Utilidades
{
    public static class SeguridadUtilidades
    {
        public static string EncriptarSHA256(string contraseña)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(contraseña);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        public static string GenerarContraseñaAleatoria(int longitud = 8)
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            var random = new Random();
            return new string(Enumerable.Repeat(caracteres, longitud).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
