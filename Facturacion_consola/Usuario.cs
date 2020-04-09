using System;

namespace Facturacion
{
    public class Usuario
    {
        #region Atributos 
        private string username;
        private string password;
        private string getUsername;
        private string getPassword;
        private bool validacion;
        #endregion
        
        public Usuario()
        {  
          username = "joel";
          password = "0412";
          getUsername = "";
          getPassword = "";
        }
        public bool login()
        {
            Console.WriteLine("Colmado Joel¡");
            do
            {
                Console.Write("Usuario:");
                getUsername = Console.ReadLine();
                Console.Write("Contraseña:");
                getPassword = Console.ReadLine();
          
                if(getUsername!=username | getPassword!=password)
                {
                    Console.WriteLine("Usuario no registrado, intentelo otra vez!");
                }
            }
            while(getUsername!=username | getPassword!=password);
            {    
                 Console.WriteLine("****************************************");
                 Console.WriteLine("*                                      *");
                 Console.WriteLine("*                                      *");
                 Console.WriteLine("          Bienvenido {0}",getUsername);
                 Console.WriteLine("*                                      *");
                 Console.WriteLine("*                                      *");
                 Console.WriteLine("****************************************");
                 Console.WriteLine("");
                 validacion = true;
                 return validacion;
            }            
        }
    }
}