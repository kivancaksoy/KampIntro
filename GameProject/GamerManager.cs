using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamerService
    {
        //MicroService (GamerManager'ın içinde bambaşka bir servis kullanmak. Ör:  IGamerService, IUserValidationService)
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
